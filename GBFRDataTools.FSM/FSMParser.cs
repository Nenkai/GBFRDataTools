using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.ComponentModel;
using System.Collections;
using System.Reflection;

using MessagePack;

using GBFRDataTools.FSM.Entities;
using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components;

namespace GBFRDataTools.FSM;

// This class attempts to parse the FSM Tree like the way the original code does (reverse-engineered)
public class FSMParser
{
    // Layers are "sub-graphs", many of these are left empty in fsms presumably because they just didn't cleanup from their end

    /// <summary>
    /// Layer indices, pointing to groups (aka non-empty layers)
    /// </summary>
    public List<int> LayerToNonEmptyLayerIndices { get; set; } = [];
    
    /// <summary>
    /// Non-empty layers
    /// </summary>
    public List<List<FSMNode>> NonEmptyLayersToNodes { get; set; } = [];

    public List<Transition> BranchTransitions { get; set; } = [];
    public List<Transition> LeafTransitions { get; set; } = [];
    public List<BehaviorTreeComponent> Components { get; set; } = [];
    public FSMNode RootNode { get; set; }

    // Not normally part of the struct
    // Using it because Transitions with only a target (aka only fromNodeGuid_) seem to refer to parent node? which we can't easily get
    public List<FSMNode> AllNodes { get; set; } = [];

    public static Dictionary<string, Type> ComponentNameToType { get; } = [];
    static FSMParser()
    {
        foreach (Type type in Assembly.GetAssembly(typeof(BehaviorTreeComponent)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BehaviorTreeComponent))))
        {
            ComponentNameToType.Add(type.Name, type);
        }
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

        FSMNode lastNode = null;
        int layerWithNodesIndex = -1;

        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            switch (elem.Name)
            {
                case "layerNo":
                    {
                        int layerNo;
                        if (elem.Value.ValueKind == JsonValueKind.Number)
                        {
                            if (!elem.Value.TryGetInt32(out layerNo))
                                throw new InvalidDataException("layerNo has invalid integer value.");
                        }
                        else if (elem.Value.ValueKind == JsonValueKind.String)
                        {
                            if (!int.TryParse(elem.Value.GetString(), out layerNo))
                                throw new InvalidDataException("layerNo has invalid integer value.");
                        }
                        else
                            throw new InvalidDataException("Invalid layerNo.");


                        LayerToNonEmptyLayerIndices.Add(layerNo);
                        NonEmptyLayersToNodes.Add([]);
                        layerWithNodesIndex++;
                    }
                    break;

                case "FSMNode":
                    {
                        // Incase. see: ba2105_aethercannon_fsm_ingame - layer may not be provided
                        if (layerWithNodesIndex == -1)
                            layerWithNodesIndex = 0;

                        if (NonEmptyLayersToNodes.Count <= layerWithNodesIndex)
                            NonEmptyLayersToNodes.Add([]);

                        if (LayerToNonEmptyLayerIndices.Count == 0)
                            LayerToNonEmptyLayerIndices.Add(0);

                        FSMNode node = JsonSerializer.Deserialize<FSMNode>(elem.Value, DefaultJsonSerializerOptions.InstanceForRead);




                        NonEmptyLayersToNodes[layerWithNodesIndex].Add(node);
                        lastNode = node;

                        AllNodes.Add(node);
                    }
                    break;

                case "Transition":
                    {
                        Transition transition = JsonSerializer.Deserialize<Transition>(elem.Value, DefaultJsonSerializerOptions.InstanceForRead);

                        if (transition.ToNodeGuid != 0)
                        {
                            BranchTransitions.Add(transition);
                            lastNode.RegularTransitions.Add(transition);
                        }
                        else
                        {
                            LeafTransitions.Add(transition);
                            lastNode.OverrideTransitions.Add(transition);
                        }
                    }
                    break;

                case "addAllTransition":
                case "addTransition":
                case "EnableBaseAllTransition":
                case "EnableBaseTransition":
                case "EnableFalseComponent":
                case "className":
                case "fsmName":
                    // TODO
                    break;

                default:
                    // Anything else is a component
                    {
                        if (!ComponentNameToType.TryGetValue(elem.Name, out Type componentType))
                            throw new NotSupportedException($"Component '{elem.Name}' is not supported.");

                        BehaviorTreeComponent component = (BehaviorTreeComponent)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);

                        Components.Add(component);

                        foreach (var nodeList in NonEmptyLayersToNodes)
                        {
                            foreach (var node in nodeList)
                            {
                                if (component.ParentGuid == node.Guid)
                                {
                                    node.ExecutionComponents.Add(component);
                                    break;
                                }
                            }
                        }
                    }
                    break;

            }
        }

        // Link transition condition guids to their components directly
        foreach (Transition transition in BranchTransitions)
        {
            foreach (uint conditionGuid in transition.ConditionGuids)
            {
                foreach (BehaviorTreeComponent component in Components)
                {
                    if (conditionGuid == component.Guid)
                    {
                        if (component is not ConditionComponent condComponent)
                            throw new InvalidDataException($"Component {component.ComponentName} ({conditionGuid}) was expected to be a ConditionComponent, but isn't");

                        transition.ConditionComponents.Add(condComponent);
                        break;
                    }
                }
            }
        }

        foreach (Transition transition in LeafTransitions)
        {
            foreach (uint conditionGuid in transition.ConditionGuids)
            {
                foreach (BehaviorTreeComponent component in Components)
                {
                    if (conditionGuid == component.Guid)
                    {
                        if (component is not ConditionComponent condComponent)
                            throw new InvalidDataException($"Component {component.ComponentName} ({conditionGuid}) was expected to be a ConditionComponent, but isn't");

                        transition.ConditionComponents.Add(condComponent);
                        break;
                    }
                }
            }
        }

        // Fsms can have nothing at all. See: ba7350_snd_1_fsm_ingame
        if (NonEmptyLayersToNodes.Count > 0 && NonEmptyLayersToNodes[0].Count > 0)
        {
            // TODO: Figure out sound fsm trees (& determine root) properly: i.e pl1100_snd_auto_base_1_fsm_ingame
            RootNode = NonEmptyLayersToNodes[0][0];
                
            int nIndex = 1;
            BuildTree(RootNode, ref nIndex, 0, NonEmptyLayersToNodes, LayerToNonEmptyLayerIndices);
        }
    }

    // Reversed - 41 57 41 56 41 55 41 54 56 57 55 53 48 83 EC ? 4C 89 CE 45 89 C6
    // NOTE (repeat): Groups are merely layers, but does not include layers with no nodes
    // Hence layerToGroupsIndices
    public static void BuildTree(FSMNode node, ref int nodeIndex, int groupIndex, List<List<FSMNode>> nodeGroups, List<int> layerToGroupsIndices)
    {
        // Non original, but added to keep track of nodes's layers
        node.LayerIndex = layerToGroupsIndices[groupIndex];

        int numNodesThisLayer = nodeIndex == 1 ? nodeGroups[groupIndex].Count - 1 : 0;
        if (node.ChildLayerId != -1 && nodeGroups.Count > 0)
        {
            int childGroupIndex = layerToGroupsIndices.IndexOf(node.ChildLayerId);
            if (childGroupIndex != -1)
            {
                var subNode = nodeGroups[childGroupIndex];

                int nIndex = 1;
                node.Children.Add(subNode[0]);
                BuildTree(subNode[0], ref nIndex, childGroupIndex, nodeGroups, layerToGroupsIndices);
            }
        }

        for (int i = 0; i < numNodesThisLayer; i++)
        {
            List<FSMNode> nodesThisLayer = nodeGroups[groupIndex];
            if (i >= nodesThisLayer.Count)
                return;

            FSMNode childNode = nodesThisLayer[nodeIndex];
            node.Children.Add(childNode);
            nodeIndex++;

            BuildTree(childNode, ref nodeIndex, groupIndex, nodeGroups, layerToGroupsIndices);
        }
    }
}
