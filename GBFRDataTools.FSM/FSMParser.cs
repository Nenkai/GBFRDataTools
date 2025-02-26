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

namespace GBFRDataTools.FSM;

// This class attempts to parse the FSM Tree like the way the original code does (reverse-engineered)
public class FSMParser
{
    // Layers are "sub-graphs", many of these are left empty in fsms presumably because they just didn't cleanup from their end

    /// <summary>
    /// Layer indices, pointing to groups (aka non-empty layers)
    /// </summary>
    public List<int> LayerToGroupIndices { get; set; } = [];
    
    /// <summary>
    /// Non-empty layers
    /// </summary>
    public List<List<FSMNode>> GroupsToNodes { get; set; } = [];

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
        int layerIndex = -1;

        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            switch (elem.Name)
            {
                case "layerNo":
                    {
                        if (!elem.Value.TryGetInt32(out int layerNo))
                            throw new InvalidDataException("layerNo has invalid integer value.");

                        LayerToGroupIndices.Add(layerNo);
                        layerIndex++;
                    }
                    break;

                case "FSMNode":
                    {
                        // Incase. see: ba2105_aethercannon_fsm_ingame - layer may not be provided
                        if (layerIndex == -1)
                            layerIndex = 0;

                        if (GroupsToNodes.Count <= layerIndex)
                            GroupsToNodes.Add([]);

                        if (LayerToGroupIndices.Count == 0)
                            LayerToGroupIndices.Add(0);

                        if (!elem.Value.TryGetProperty("guid_", out JsonElement guid_) || !guid_.TryGetInt32(out int guid))
                            throw new InvalidDataException("FSMNode is missing or invalid mandatory 'guid_' property.");

                        int childLayerId = -1;

                        // Not mandatory. See: ba2105_aethercannon_fsm_ingame
                        if (elem.Value.TryGetProperty("childLayerId_", out JsonElement childLayerId_) && !childLayerId_.TryGetInt32(out childLayerId))
                            throw new InvalidDataException("Transition has invalid 'childLayerId_' property.");

                        string fsmName = null;
                        if (elem.Value.TryGetProperty("fsmName_", out JsonElement fsmName_))
                            fsmName = fsmName_.GetString();

                        string fsmFolderName = null;
                        if (elem.Value.TryGetProperty("fsmFolderName_", out JsonElement fsmFolderName_))
                            fsmFolderName = fsmFolderName_.GetString();

                        var node = new FSMNode()
                        {
                            Guid = guid,
                            ChildLayerId = childLayerId,
                            FsmName = fsmName,
                            FsmFolderName = fsmFolderName,
                        };

                        GroupsToNodes[layerIndex].Add(node);
                        lastNode = node;

                        AllNodes.Add(node);
                    }
                    break;

                case "Transition":
                    {
                        if (!elem.Value.TryGetProperty("toNodeGuid_", out JsonElement toNodeGuid_) || !toNodeGuid_.TryGetInt32(out int toNodeGuid))
                            throw new InvalidDataException("Transition is missing or invalid mandatory 'toNodeGuid_' property.");

                        if (!elem.Value.TryGetProperty("fromNodeGuid_", out JsonElement fromNodeGuid_) || !fromNodeGuid_.TryGetInt32(out int fromNodeGuid))
                            throw new InvalidDataException("Transition is missing or invalid mandatory 'fromNodeGuid_' property.");

                        Transition transition = new(toNodeGuid, fromNodeGuid);

                        if (elem.Value.TryGetProperty("isEndTransition_", out JsonElement isEndTransition_))
                            transition.IsEndTransition = isEndTransition_.GetBoolean();

                        // Not mandatory
                        if (elem.Value.TryGetProperty("conditionGuids_", out JsonElement conditionGuids_))
                        {
                            foreach (JsonElement element in conditionGuids_.EnumerateArray())
                            {
                                int conditionGuid = element.GetProperty("Element").GetInt32();
                                transition.ConditionGuids.Add(conditionGuid);
                            }
                        }

                        if (transition.ToNodeGuid != 0)
                        {
                            BranchTransitions.Add(transition);
                            lastNode.BranchTransitions.Add(transition);
                        }
                        else
                        {
                            LeafTransitions.Add(transition);
                            lastNode.LeafTransitions.Add(transition);
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

                        BehaviorTreeComponent component = (BehaviorTreeComponent)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.Instance);
                        component.ComponentName = elem.Name;

                        Components.Add(component);

                        foreach (var nodeList in GroupsToNodes)
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
            foreach (int conditionGuid in transition.ConditionGuids)
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
            foreach (int conditionGuid in transition.ConditionGuids)
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
        if (GroupsToNodes.Count > 0 && GroupsToNodes[0].Count > 0)
        {
            // TODO: Figure out sound fsm trees (& determine root) properly: i.e pl1100_snd_auto_base_1_fsm_ingame
            RootNode = GroupsToNodes[0][0];
                
            int nIndex = 1;
            BuildTree(RootNode, ref nIndex, 0, GroupsToNodes, LayerToGroupIndices);
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
