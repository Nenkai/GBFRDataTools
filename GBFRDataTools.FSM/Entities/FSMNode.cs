using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BTInGame::FSMNode
public class FSMNode
{
    public List<FSMNode> Children { get; set; } = [];
    public List<BehaviorTreeComponent> ExecutionComponents { get; set; } = [];
    public uint Guid; // exposed as guid_
    public int ChildLayerId { get; set; } = -1; // exposed as childLayerId_
    public string FsmName { get; set; }
    public string FsmFolderName { get; set; }
    public int TailIndexOfChildNodeGuids { get; set; }
    public List<Transition> BranchTransitions = [];
    public List<Transition> LeafTransitions = [];

    // Not part of the game's struct, but useful to have
    public int LayerIndex;

    // "Emulation" code starts from here
    public FSMNode SelectedNode { get; set; }
    public int Flag;
    public int State;

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
                foreach (var transition in node.LeafTransitions)
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
                    foreach (var transition in sub.BranchTransitions)
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
                foreach (var transition in node.BranchTransitions)
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

        foreach (var trans in target.BranchTransitions)
        {

        }

        return target;
    }
}
