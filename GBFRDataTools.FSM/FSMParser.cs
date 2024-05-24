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
using GBFRDataTools.FSM.Converters;
using System.Reflection.Metadata.Ecma335;

namespace RelinkFSMToolkit;

// This class attempts to parse the FSM Tree like the way the original code does (reverse-engineered)
public class FSMParser
{
    public List<int> LayerIndices { get; set; } = new List<int>();
    public List<List<FSMNode>> LayersToNodes { get; set; } = new List<List<FSMNode>>();
    public List<Transition> BranchTransitions { get; set; } = new List<Transition>();
    public List<Transition> LeafTransitions { get; set; } = new List<Transition>();
    public List<BehaviorTreeComponent> Components { get; set; } = new List<BehaviorTreeComponent>();
    public FSMNode RootNode { get; set; }

    // Not normally part of the struct
    // Using it because Transitions with only a target (aka only fromNodeGuid_) seem to refer to parent node? which we can't easily get
    public List<FSMNode> AllNodes { get; set; } = new List<FSMNode>();

    public static Dictionary<string, Type> ComponentNameToType { get; } = [];
    static FSMParser()
    {
        foreach (Type type in Assembly.GetAssembly(typeof(BehaviorTreeComponent)).GetTypes()
            .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BehaviorTreeComponent))))
        {
            ComponentNameToType.Add(type.Name, type);
        }
    }

    public void Parse(string fileName)
    {
        string json;
        if (fileName.EndsWith(".msg"))
        {
            if (!File.Exists(fileName))
                return;

            byte[] data = File.ReadAllBytes(fileName);
            json = MessagePackSerializer.ConvertToJson(data);
        }
        else
            json = File.ReadAllText(fileName);

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

                        LayerIndices.Add(layerNo);
                        layerIndex++;
                    }
                    break;

                case "FSMNode":
                    {
                        if (LayersToNodes.Count <= layerIndex)
                            LayersToNodes.Add(new List<FSMNode>());

                        if (!elem.Value.TryGetProperty("guid_", out JsonElement guid_) || !guid_.TryGetInt32(out int guid))
                            throw new InvalidDataException("FSMNode is missing or invalid mandatory 'guid_' property.");

                        if (!elem.Value.TryGetProperty("childLayerId_", out JsonElement childLayerId_) || !childLayerId_.TryGetInt32(out int childLayerId))
                            throw new InvalidDataException("Transition is missing or invalid mandatory 'childLayerId_' property.");

                        var node = new FSMNode()
                        {
                            Guid = guid,
                            ChildLayerId = childLayerId
                        };

                        LayersToNodes[layerIndex].Add(node);
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

                        Transition transition = new Transition(toNodeGuid, fromNodeGuid);

                        if (!elem.Value.TryGetProperty("conditionGuids_", out JsonElement conditionGuids_))
                            throw new InvalidDataException("Conditional Transition is missing mandatory 'conditionGuids_' property.");

                        foreach (JsonElement element in conditionGuids_.EnumerateArray())
                        {
                            int conditionGuid = element.GetProperty("Element").GetInt32();
                            transition.ConditionGuids.Add(conditionGuid);
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
                        var jsonSerializerOptions = new JsonSerializerOptions()
                        {
                            UnmappedMemberHandling = System.Text.Json.Serialization.JsonUnmappedMemberHandling.Disallow,
                        };
                        jsonSerializerOptions.Converters.Add(new ElementArrayConverter());
                        jsonSerializerOptions.Converters.Add(new cVec2Converter());
                        jsonSerializerOptions.Converters.Add(new cVec4Converter());
                        jsonSerializerOptions.Converters.Add(new ControllerConverter());

                        if (!ComponentNameToType.TryGetValue(elem.Name, out Type componentType))
                            throw new NotSupportedException($"Component '{elem.Name}' is not supported.");

                        BehaviorTreeComponent component = (BehaviorTreeComponent)JsonSerializer.Deserialize(elem.Value, componentType, jsonSerializerOptions);
                        component.ComponentName = elem.Name;

                        Components.Add(component);

                        foreach (var nodeList in LayersToNodes)
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
                        transition.ConditionComponents.Add(component);
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
                        transition.ConditionComponents.Add(component);
                        break;
                    }
                }
            }
        }


        RootNode = LayersToNodes[0][0];
        int nIndex = 1;
        BuildTree(RootNode, ref nIndex, 0, LayersToNodes, LayerIndices);
    }

    // Reversed - 41 57 41 56 41 55 41 54 56 57 55 53 48 83 EC ? 4C 89 CE 45 89 C6
    public void BuildTree(FSMNode node, ref int nodeIndex, int layerIndex, List<List<FSMNode>> layersToNodes, List<int> layerIndices)
    {
        int numNodesThisLayer = nodeIndex == 1 ? layersToNodes[layerIndex].Count - 1 : 0;
        if (node.ChildLayerId != -1)
        {
            if (layersToNodes.Count > 0)
            {
                int max = layerIndices.Count > 1 ? layerIndices.Count : 1;
                for (int i = 0; i < max; i++)
                {
                    if (node.ChildLayerId == layerIndices[i])
                    {
                        int nIndex = 1;
                        node.Children.Add(layersToNodes[i][0]);
                        BuildTree(layersToNodes[i][0], ref nIndex, i, layersToNodes, layerIndices);
                        if (numNodesThisLayer == 0)
                            return;
                        else
                            break;
                    }
                }
            }
        }

        for (int i = 0; i < numNodesThisLayer; i++)
        {
            List<FSMNode> nodesThisLayer = layersToNodes[layerIndex];
            if (i >= nodesThisLayer.Count)
                return;

            FSMNode childNode = nodesThisLayer[nodeIndex];
            node.Children.Add(childNode);
            nodeIndex++;

            BuildTree(childNode, ref nodeIndex, layerIndex, layersToNodes, layerIndices);
        }
    }
}
