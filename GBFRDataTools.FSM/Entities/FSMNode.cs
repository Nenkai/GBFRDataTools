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
    #region Original file properties
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
    public string? FsmName { get; set; }

    [JsonPropertyName("fsmFolderName_")]
    public string? FsmFolderName { get; set; }

    [JsonPropertyName("referenceguid_")]
    public uint ReferenceGuid { get; set; }
    #endregion

    #region Original engine properties
    /// <summary>
    /// Ending transitions.
    /// </summary>
    [JsonIgnore]
    public List<Transition> EndTransitions = [];

    /// <summary>
    /// Failed transitions.
    /// </summary>
    [JsonIgnore]
    public List<Transition> FailedTransitions = [];

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
    /// Number of child nodes for this layer. This is only populated for the root node of the current layer.
    /// </summary>
    [JsonIgnore]
    public List<FSMNode> Children { get; set; } = [];

    [JsonIgnore]
    public List<BehaviorTreeComponent> ExecutionComponents { get; set; } = [];
    #endregion

    #region Custom properties
    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Not used by the game or present at all, using this for external third-party editors.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("childLayerName")]
    public string? ChildLayerName { get; set; }

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

    // Not part of the game's struct, but useful to have
    [JsonIgnore]
    public int LayerIndex;
    #endregion

    public override string ToString()
    {
        return $"{Guid} (ChildLayerId: {ChildLayerId}, Children: {Children.Count})";
    }

    public FSMNode(uint guid)
    {
        Guid = guid;
    }

    // 2.0.x ER: 41 57 41 56 41 55 41 54 56 57 55 53 48 83 EC ? 48 89 D7 48 89 CE 80 7A
    public void AddTransition(Transition transition)
    {
        if (transition.IsEndTransition)
        {
            if (!EndTransitions.Contains(transition)) // Added
                EndTransitions.Add(transition);
        }
        else if (transition.IsFailedTransition)
        {
            if (!FailedTransitions.Contains(transition))
                FailedTransitions.Add(transition);
        }
        else
        {
            if (!RegularTransitions.Contains(transition))
                RegularTransitions.Add(transition);
        }
    }

    // 2.0.x ER: 41 57 41 56 41 55 41 54 56 57 55 53 48 83 EC ? 49 89 D6 48 89 CE 48 8B 99 ? ? ? ? 48 3B 99 ? ? ? ? 74 ? 4C 89 33 48 83 86 ? ? ? ? ? E9 ? ? ? ? 49 89 DC 4C 2B A6 ? ? ? ? 49 C1 FC ? 49 8D 6C 24 ? 4D 89 E5 49 D1 ED 48 B8 ? ? ? ? ? ? ? ? 48 89 C1 4C 29 E9 4D 01 E5 49 39 ED 4C 0F 46 ED 49 39 CC 4C 0F 47 E8 4A 8D 0C ED ? ? ? ? 48 85 C9 74 ? BA ? ? ? ? E8 ? ? ? ? 48 89 C7 4C 8B BE ? ? ? ? 4E 89 34 E0 49 29 DF 74 ? 4E 8D 24 E7 49 83 C4 ? 4C 8B B6 ? ? ? ? 49 89 D8 4D 29 F0 48 89 F9 4C 89 F2 E8 ? ? ? ? 4C 89 E1 48 89 DA 4D 89 F8 EB ? 4E 89 34 E5 ? ? ? ? 31 FF 4C 8B B6 ? ? ? ? 4C 29 F3 48 89 F9 4C 89 F2 49 89 D8 E8 ? ? ? ? 4D 85 F6 74 ? 4C 89 F0 48 25 ? ? ? ? 74 ? 65 4C 8B 04 25 ? ? ? ? 44 89 F2 81 E2 ? ? ? ? 0F B6 48 ? 48 D3 EA 4C 3B 40 ? 75 ? 48 C1 E2 ? 80 7C 10 ? ? 75 ? 48 8B 8C 10 ? ? ? ? 49 89 0E 4C 89 B4 10 ? ? ? ? FF 8C 10 ? ? ? ? 74 ? 48 89 BE ? ? ? ? 48 8D 04 EF 48 89 86 ? ? ? ? 4A 8D 04 EF 48 89 86 ? ? ? ? 48 83 C4 ? 5B 5D 5F 5E 41 5C 41 5D 41 5E 41 5F C3 4C 3B 40 ? 0F 94 C2 48 89 C1 4D 89 F0 E8 ? ? ? ? EB ? 48 8D 0C 10 48 83 C1 ? E8 ? ? ? ? EB ? CC CC 41 57
    public void AddOverrideTransition(Transition transition)
    {
        if (!OverrideTransitions.Contains(transition)) // Added
            OverrideTransitions.Add(transition);
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
