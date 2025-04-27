using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.BehaviorTree;
using GBFRDataTools.FSM.Components;
using GBFRDataTools.FSM.Components.Actions.UI;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;
using GBFRDataTools.FSM.Components.Conditions.UI.Pause;
using GBFRDataTools.FSM.Entities;

using MessagePack;

using Microsoft.Extensions.Logging;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM;

public class BTParser
{
    private ILogger? _logger;

    /// <summary>
    /// Not original, used to specify whether the tree has editor settings such as node names and boundary boxes
    /// </summary>
    public FsmEditorSettings EditorSettings { get; set; }

    private static List<Type> _nodeTypes =
    [
        typeof(RootNode),
        typeof(SelectorNode),
        typeof(DecorationNode),
        typeof(SequencerNode),
        typeof(ActionNode),
        typeof(NoFailedSequencerNode),
        typeof(RandomSelectorNode),
        typeof(RandomSelectorEmNode),
        typeof(ReferenceTreeNode),
        typeof(FSMNodeForBT),
    ];
    public static Dictionary<string, Type> NodeTypeToType { get; } = [];

    public static Dictionary<string, Type> ComponentNameToType { get; } = [];

    static BTParser()
    {
        foreach (Type type in Assembly.GetAssembly(typeof(BehaviorTreeComponent)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BehaviorTreeComponent))))
        {
            ComponentNameToType.Add(type.Name, type);

#if DEBUG
            var obj = (BehaviorTreeComponent)Activator.CreateInstance(type);
            if (obj.ComponentName != type.Name)
                Debug.WriteLine($"ComponentName for {type.Name} does not match");
        }
#endif

        foreach (Type type in _nodeTypes)
            NodeTypeToType.Add(type.Name, type);
    }

    //public static SortedDictionary<string, Dictionary<string, SortedDictionary<int, EnumString>>> _compToEnums = [];

    public List<TreeNode> TreeNodes { get; set; } = [];
    public Dictionary<uint, TreeNode> NodeMap { get; set; } = [];
    public List<BehaviorTreeComponent> Components { get; set; } = [];
    public RootNode RootNode { get; set; }
    public bool HasErrors { get; private set; }

    public BTParser(ILoggerFactory loggerFactory = null)
    {
        _logger = loggerFactory?.CreateLogger<BTParser>();
    }

    public void Parse(byte[] data, bool asMessagePack = false)
    {
        string json;
        if (asMessagePack)
        {
            json = MessagePackSerializer.ConvertToJson(data);
        }
        else
            json = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(json);

        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            if (NodeTypeToType.TryGetValue(elem.Name, out Type type))
            {
                TreeNode node = (TreeNode)elem.Value.Deserialize(type, DefaultJsonSerializerOptions.InstanceForRead);
                if (node is RootNode rootNode)
                {
                    if (RootNode is not null)
                        throw new InvalidDataException("Root node was already declared in behavior tree.");

                    RootNode = rootNode;
                }

                TreeNodes.Add(node);
                if (!NodeMap.TryAdd(node.Guid, node))
                {
                    // em7001_state
                    _logger.LogWarning("Duplicate guid node found (guid: {guid}, type: {type})", node.Guid, elem.Name);
                }
            }
            else if (ComponentNameToType.TryGetValue(elem.Name, out Type componentType))
            {
                BehaviorTreeComponent comp = (BehaviorTreeComponent)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);
                Components.Add(comp);
            }
            else if (elem.Name == "SubBehaviorTreeData")
            {
                // Not supported by the game
                _logger.LogWarning("BehaviorTree has 'SubBehaviorTreeData' which is not supported (not read by the game either)");
                continue;
            }
            else
            {
                switch (elem.Name)
                {
                    case "Em0006GuardAction":
                    case "Em0010EscapeAction":
                        throw new NotSupportedException($"Behavior Tree element '{elem.Name}' not supported (game doesn't support it either)");
                }

                throw new NotSupportedException($"Behavior Tree element '{elem.Name}' not supported");
            }
        }

        BuildTree();
    }

    private void BuildTree()
    {
        CompositeNode root = RootNode;
        int idx = 1;
        Dive(ref root, ref idx);


        foreach (BehaviorTreeComponent component in Components)
        {
            if (!NodeMap.TryGetValue(component.ParentGuid, out TreeNode parentNode))
            {
                _logger.LogWarning("Node {parentGuid} referenced by component {guid} ({name}) was not found in behavior tree.", component.ParentGuid, component.Guid, component.ComponentName);
                continue;
            }

            if (parentNode is ActionNode actionNode)
            {
                actionNode.Actions.Add(component);
            }
            else if (parentNode is DecorationNode decorationNode)
            {
                decorationNode.BehaviorTreeComponent.Add(component);
            }
            else
                throw new NotSupportedException();
        }
    }

    private void Dive(ref CompositeNode parent, ref int idx)
    {
        for (int i = 0; i < parent.TailIndexOfChildNodeGuids; i++)
        {
            TreeNode node = TreeNodes[idx];
            parent.Children.Add(node);
            idx++;

            if (node is ActionNode actionn)
                ;

            if (node is CompositeNode compositeNode && compositeNode.TailIndexOfChildNodeGuids != 0)
            {
                Dive(ref compositeNode, ref idx);
            }
            else if (node.TailIndexOfChildNodeGuids != 0)
                throw new NotSupportedException();
        }
    }
}
