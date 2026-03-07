using GBFRDataTools.FSM.Components;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BTInGame::FSMNode
public class FSMNode
{
    [JsonPropertyName("guid_")]
    public uint Guid { get; set; }

    /// <summary>
    /// Last index of the child nodes (current layer only). Only populated for the root node of each layer.
    /// </summary>
    [JsonPropertyName("tailIndexOfChildNodeGuids_")]
    public int TailIndexOfChildNodeGuids { get; set; }

    [JsonPropertyName("tailIndexOfComponentGuids_")]
    public int TailIndexOfComponentGuids { get; set; }

    [JsonPropertyName("childLayerId_")]
    public int ChildLayerId { get; set; } = -1;

    /// <summary>
    /// CRC32("<string>".ToLower())
    /// </summary>
    [JsonPropertyName("nameHash_")]
    public uint NameHash { get; set; }

    [JsonPropertyName("isBranch_")]
    public bool IsBranch { get; set; }

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; }

    [JsonPropertyName("fsmFolderName_")]
    public string FsmFolderName { get; set; }

    [JsonPropertyName("referenceguid_")]
    public uint ReferenceGuid { get; set; }

    /// <summary>
    /// Number of child nodes for this layer. This is only populated for the root node of the current layer.
    /// </summary>
    [JsonIgnore]
    public List<FSMNode> Children { get; set; } = [];

    [JsonIgnore]
    public List<BehaviorTreeComponent> ExecutionComponents { get; set; } = [];

    // Not part of the game's struct, but useful to have
    [JsonIgnore]
    public int LayerIndex;
    
    /// <summary>
    /// These transitions are evaluated once and their result cached, as the game navigates through the tree on every frame.
    /// </summary>
    [JsonIgnore]
    public List<Transition> RegularTransitions = [];

    /// <summary>
    /// These transitions are always evaluated when the game navigates the FSM tree to the last evaluated node on every frame. <br/>
    /// Useful to interrupt the current flow.
    /// </summary>
    [JsonIgnore]
    public List<Transition> OverrideTransitions = [];

    // "Emulation" code starts from here
    [JsonIgnore]
    public FSMNode SelectedNode { get; set; }

    [JsonIgnore]
    public int Flag;

    [JsonIgnore]
    public int State;

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("childLayerName")]
    public string ChildLayerName { get; set; }

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("boundary_box")]
    public Vector4 BoundaryBox { get; set; }

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("child_layer_boundary_box")]
    public Vector4 ChildLayerBoundaryBox { get; set; }

    public override string ToString()
    {
        return $"{Guid} (ChildLayerId: {ChildLayerId}, Children: {Children.Count})";
    }

    public FSMNode(uint guid)
    {
        Guid = guid;
    }

    // 1.1.1 - 141846B00
    // PS4 1.0.0 - sub_1A87C00 (this function is inlined within this one, but more readable)
    // Might be vaguely inaccurate, flow is hard to recover
    public void ExecuteNode()
    {
        FSMNode node = this;
        while (true)
        {
            if (node.Children.Count == 0)
                break;

            // The game caches the next nodes that were already selected, to navigate through the tree
            while (node.SelectedNode is not null)
            {
                foreach (var transition in node.OverrideTransitions)
                {
                    if (/*transition->flag*/ true && transition.FromNodeGuid != node.Guid && transition.Execute(0))
                    {
                        // Loop thru components to do smth possibly unimportant (led to nullsub)
                        node = node.SelectNode(transition.FromNodeGuid);
                        if (node is not null)
                            goto Done;
                    }
                }

                if (node.ChildLayerId == -1) // node.GetLayerIndex()
                {
                    var sub = node.SelectedNode;
                    foreach (var transition in sub.RegularTransitions)
                    {
                        if (/*transition->flag*/true)
                        {
                            var subsub = sub.SelectedNode;
                            int flag = subsub.Flag;
                            if (flag != 0)
                            {
                                if (subsub.State == 2)
                                    flag |= 0x10;
                                if ((subsub.Flag & 0x10) != 0)
                                    flag |= 0x10;
                            }

                            // Weird stuff

                            if (transition.Execute(flag))
                            {
                                // Loop thru components to do smth possibly unimportant (led to nullsub)
                                node = node.SelectNode(transition.FromNodeGuid);
                                if (node is not null)
                                    goto Done;
                            }
                        }
                    }
                }

            Done:
                if (node.Children.Count == 0)
                    return;
            }

            // We need to select a node.
            bool done = true;
            if (node.SelectedNode is null && node.ChildLayerId != -1 && node.Children.Count != 0)
            {
                node = node.SelectNode(node.Children[0].Guid);
                if (node is not null)
                    continue;
            }
            else
            {
                foreach (var transition in node.RegularTransitions)
                {
                    if (/*transition->flag*/ true && transition.Execute(0))
                    {
                        // Loop thru components
                        node = node.SelectNode(transition.FromNodeGuid);
                        if (node is not null)
                        {
                            done = false;
                            continue;
                        }
                    }
                }
            }

            if (done)
                return;
        }
    }

    // 1.1.1 - 1418470C0
    public FSMNode SelectNode(uint guid)
    {
        FSMNode target = null;
        foreach (FSMNode child in Children)
        {
            if (child.Guid == guid)
            {
                target = child;
                break;
            }
        }

        if (target is null)
            return null;

        if (SelectedNode is not null)
        {
            // ...
        }

        SelectedNode = target;

        foreach (var trans in target.RegularTransitions)
        {

        }

        return target;
    }
}
