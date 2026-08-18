using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components;
using GBFRDataTools.FSM.Components.Actions.UI;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;
using GBFRDataTools.FSM.Components.Conditions.UI.Pause;
using GBFRDataTools.FSM.Entities;

using MessagePack;

using Microsoft.Extensions.Logging;

namespace GBFRDataTools.FSM;

// This class attempts to parse the FSM Tree like the way the original code does (reverse-engineered)
public class FSMParser
{
    private readonly ILogger? _logger;
    private readonly string? _baseDir;

    public bool HasErrors { get; private set; }

    public string? FileName { get; set; }

    // These properties are part of FSMLoaderImpl (game's loader)
    #region Original properties
    /// <summary>
    /// Layer indices, pointing to groups (aka non-empty layers)
    /// </summary>
    public List<int> LayerToNonEmptyLayerIndices { get; set; } = [];

    /// <summary>
    /// Non-empty layers
    /// </summary>
    // Layers are "sub-graphs", many of these are left empty in fsms presumably because they just didn't cleanup from their end
    public List<List<FSMNode>> LayersToNodes { get; set; } = [];

    public List<Transition> NormalTransitions { get; set; } = [];
    public List<Transition> OverrideTransitions { get; set; } = [];
    public List<BehaviorTreeComponent> Components { get; set; } = [];
    public FSMNode RootNode { get; set; }
    public FSMParser? BaseFSMParser { get; set; }
    #endregion 

    /// <summary>
    /// Not original, used to specify whether the tree has editor settings such as node names and boundary boxes
    /// </summary>
    public FsmEditorSettings? EditorSettings { get; set; }

    public static Dictionary<string, Type> ComponentNameToType { get; } = [];
    static FSMParser()
    {
        var assembly = Assembly.GetAssembly(typeof(BehaviorTreeComponent));
        if (assembly is not null)
        {
            foreach (Type type in assembly.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(BehaviorTreeComponent))))
            {
                ComponentNameToType.Add(type.Name, type);
            }
        }
    }

    //public static SortedDictionary<string, Dictionary<string, SortedDictionary<int, EnumString>>> _compToEnums = [];

    public FSMParser(ILoggerFactory? loggerFactory = null, string baseDir = "")
    {
        _logger = loggerFactory?.CreateLogger<FSMParser>();

        _baseDir = baseDir;
    }

    private FSMParser(ILogger? logger, string? baseDir = "")
    {
        _logger = logger;
        _baseDir = baseDir;
    }

    public async Task Parse(string file)
    {
        FileName = file;
        await Parse(File.ReadAllBytes(file), file.EndsWith(".msg"));
    }

    public delegate Task<string?> LocateFSMFileDelegate(string file);

    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //                   BIG NOTE
    // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    // Some Cy engineer can't make the difference between "from" and "to"
    // In this context, TO = SOURCE, FROM = TARGET
    // so "FromNodeGuid" or "FromGuid" = TARGET NODE!! Not SOURCE!!
    //
    // Hammer this into your brain!

    public async Task Parse(byte[] data, bool asMessagePack = false, LocateFSMFileDelegate? onRequestNotFoundBaseFile = null)
    {
        string json;
        if (asMessagePack)
        {
            json = MessagePackSerializer.ConvertToJson(data);
        }
        else
            json = Encoding.UTF8.GetString(data);

        JsonDocument doc = JsonDocument.Parse(json);

        FSMNode? lastNode = null;
        int layerWithNodesIndex = -1;

        // The game breaks this down into two passes:
        // 1. Making a list of generic nodes to parse, with some nodes pre-processed
        // 2. Actually parsing those nodes

        HashSet<uint> ignoredComponents = []; // Component guids
        HashSet<uint> enableBaseAllTransitions = []; // Node guids for transition FromGuid (override transitions)
        HashSet<(uint, uint)> enableBaseTransitionsPairs = []; // ToGuid/FromGuid pair for regular transitions

        // Pass 1 - Preprocessed elements
        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            switch (elem.Name)
            {
                case "EnableFalseComponent": // Used to ignore components from being imported from base.
                    if (!elem.Value.TryGetUInt32(out uint componentGuid))
                    {
                        _logger?.LogError("Invalid 'EnableFalseComponent'");
                        HasErrors = true;
                        break;
                    }

                    ignoredComponents.Add(componentGuid);
                    break;

                case "EnableBaseAllTransition": // Override transitions to ignore upon importing a base FSM
                    // List of EnableFalseTransition (node guid)
                    {
                        foreach (var enableBaseAllElem in elem.Value.EnumerateObject())
                        {
                            if (enableBaseAllElem.Name == "EnableFalseTransition") // NOTE: the game doesn't even read 'EnableFalseTransition'. It just gets a uint32 directly.
                            {
                                uint guid = enableBaseAllElem.Value.GetUInt32();
                                enableBaseAllTransitions.Add(guid);
                            }
                            else
                            {
                                HasErrors = true;
                                _logger?.LogWarning("Unknown EnableBaseAllTransition attribute '{attr}'", enableBaseAllElem.Name);
                            }
                        }
                    }
                    break;

                case "EnableBaseTransition": // Regular transitions to ignore upon importing a base FSM
                    // List of EnableFalseTransition (ToGuid/FromGuid guid pair)

                    foreach (var enableBaseAllElem in elem.Value.EnumerateObject())
                    {
                        if (enableBaseAllElem.Name == "EnableFalseTransition")
                        {
                            if (!enableBaseAllElem.Value.TryGetProperty("ToGuid"u8, out JsonElement toGuidElement))
                            {
                                HasErrors = true;
                                _logger?.LogWarning("EnableFalseTransition in EnableBaseTransition missing ToGuid attribute");
                                continue;
                            }

                            if (!toGuidElement.TryGetUInt32(out uint toGuid))
                            {
                                HasErrors = true;
                                _logger?.LogWarning("EnableFalseTransition in EnableBaseTransition has invalid ToGuid");
                                continue;
                            }

                            if (!enableBaseAllElem.Value.TryGetProperty("FromGuid"u8, out JsonElement fromGuidElement))
                            {
                                HasErrors = true;
                                _logger?.LogWarning("EnableFalseTransition in EnableBaseTransition missing ToGuid attribute");
                                continue;
                            }

                            if (!fromGuidElement.TryGetUInt32(out uint fromGuid))
                            {
                                HasErrors = true;
                                _logger?.LogWarning("EnableFalseTransition in EnableBaseTransition has invalid 'FromGuid'");
                                continue;
                            }

                            enableBaseTransitionsPairs.Add((toGuid, fromGuid));
                        }
                        else
                        {
                            HasErrors = true;
                            _logger?.LogWarning("Unknown EnableBaseTransition attribute '{attr}'", enableBaseAllElem.Name);
                        }
                    }
                    break;
            }
        }


        string? className = null;
        foreach (var elem in doc.RootElement.EnumerateObject())
        {
            switch (elem.Name)
            {
                // Non original
                case "EditorSettings":
                    EditorSettings = JsonSerializer.Deserialize<FsmEditorSettings>(elem.Value, DefaultJsonSerializerOptions.InstanceForRead);
                    break;

                case "EnableFalseComponent":
                case "EnableBaseTransition":
                case "EnableBaseAllTransition":
                    break; // Already pre-processed.

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

                        int existingIndex = LayerToNonEmptyLayerIndices.IndexOf(layerNo);
                        if (existingIndex >= 0)
                        {
                            layerWithNodesIndex = existingIndex;
                        }
                        else
                        {
                            LayerToNonEmptyLayerIndices.Add(layerNo);
                            LayersToNodes.Add([]);
                            layerWithNodesIndex = LayerToNonEmptyLayerIndices.Count - 1;
                        }
                    }
                    break;
                case "FSMNode":
                    {
                        // Incase. see: ba2105_aethercannon_fsm_ingame - layer may not be provided
                        if (layerWithNodesIndex == -1)
                            layerWithNodesIndex = 0;

                        if (LayersToNodes.Count <= layerWithNodesIndex)
                            LayersToNodes.Add([]);

                        if (LayerToNonEmptyLayerIndices.Count == 0)
                            LayerToNonEmptyLayerIndices.Add(0);

                        FSMNode? node = JsonSerializer.Deserialize<FSMNode>(elem.Value, DefaultJsonSerializerOptions.InstanceForRead);
                        if (node is null)
                        {
                            _logger?.LogError("Failed to deserialize FSMNode.");
                            HasErrors = true;
                            break;
                        }

                        LayersToNodes[layerWithNodesIndex].Add(node);
                        lastNode = node;
                    }
                    break;

                case "Transition":
                    {
                        Transition? transition = JsonSerializer.Deserialize<Transition>(elem.Value, DefaultJsonSerializerOptions.InstanceForRead);
                        if (transition is null)
                        {
                            _logger?.LogError("Failed to deserialize Transition.");
                            HasErrors = true;
                            break;
                        }

                        if (lastNode is null)
                        {
                            _logger?.LogError("Got Transition without a previously defined FSMNode.");
                            HasErrors = true;
                            break;
                        }

                        if (transition.ToNodeGuid != 0)
                        {
                            NormalTransitions.Add(transition);
                            lastNode.AddTransition(transition);
                        }
                        else
                        {
                            OverrideTransitions.Add(transition);
                            lastNode.AddOverrideTransition(transition);
                        }
                    }
                    break;

                case "className":
                    {
                        className = elem.Value.GetString();
                    }
                    break;
                case "fsmName": // Loads a BASE fsm (className must be preceded)
                    {
                        if (string.IsNullOrWhiteSpace(className))
                        {
                            _logger?.LogError("'fsmName' provided without a valid className.");
                            HasErrors = true;
                        }

                        string? fsmName = elem.Value.GetString();
                        if (string.IsNullOrWhiteSpace(fsmName))
                        {
                            _logger?.LogWarning("'fsmName' is empty.");
                            HasErrors = true;
                        }

                        BaseFSMParser = new FSMParser(_logger, _baseDir);

                        string file = $"system/FSM/{className}/{className}_{fsmName}_fsm_ingame.msg"; // system/FSM/{0}/{0}_{1}_fsm_ingame.yml
                        string? path = Path.Combine(_baseDir ?? string.Empty, file);
                        if (string.IsNullOrWhiteSpace(_baseDir) || !File.Exists(path))
                        {
                            if (onRequestNotFoundBaseFile is null)
                            {
                                _logger?.LogError("Base FSM file '{}' not found. Bailing FSM load.", file);
                                HasErrors = true;
                                return;
                            }

                            path = await onRequestNotFoundBaseFile($"{className}_{fsmName}_fsm_ingame.msg");
                            if (string.IsNullOrWhiteSpace(path))
                            {
                                _logger?.LogError("Base FSM file '{}' not found. Bailing FSM load.", file);
                                HasErrors = true;
                                return;
                            }
                        }

                        await BaseFSMParser.Parse(File.ReadAllBytes(path), asMessagePack: true);

                        // Essentially, we merge the child fsm with current fsm (this is what the game does)

                        // NOTE: The game normally creates a new reflected component/transition for each imported element.
                        // We don't do that here, don't see an immediate need. Just import them.
                        foreach (BehaviorTreeComponent component in BaseFSMParser.Components)
                        {
                            if (ignoredComponents.Contains(component.Guid))
                                continue;

                            Components.Add(component);
                        }

                        foreach (Transition transition in BaseFSMParser.NormalTransitions)
                        {
                            if (enableBaseTransitionsPairs.Contains((transition.ToNodeGuid, transition.FromNodeGuid)))
                                continue;

                            NormalTransitions.Add(transition);
                        }

                        foreach (Transition transition in BaseFSMParser.OverrideTransitions)
                        {
                            if (enableBaseAllTransitions.Contains(transition.FromNodeGuid))
                                continue;

                            OverrideTransitions.Add(transition);
                        }

                        // This is assigned directly
                        LayerToNonEmptyLayerIndices = BaseFSMParser.LayerToNonEmptyLayerIndices;

                        foreach (List<FSMNode> layer in BaseFSMParser.LayersToNodes)
                        {
                            // The game also creates a new node normally. We simply add the whole layer
                            LayersToNodes.Add(layer);

                            // Link up transitions for each node
                            foreach (FSMNode node in layer)
                            {
                                // Normal/End/Failed
                                int count = node.RegularTransitions.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    var nodeTransition = node.RegularTransitions[i];
                                    foreach (Transition trans in NormalTransitions)
                                    {
                                        if (trans.ToNodeGuid == nodeTransition.ToNodeGuid && trans.FromNodeGuid == nodeTransition.FromNodeGuid)
                                            node.AddTransition(trans);
                                    }
                                }

                                count = node.EndTransitions.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    var nodeTransition = node.EndTransitions[i];
                                    foreach (Transition trans in NormalTransitions)
                                    {
                                        if (trans.ToNodeGuid == nodeTransition.ToNodeGuid && trans.FromNodeGuid == nodeTransition.FromNodeGuid)
                                            node.AddTransition(trans);
                                    }
                                }

                                count = node.FailedTransitions.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    var nodeTransition = node.FailedTransitions[i];
                                    foreach (Transition trans in NormalTransitions)
                                    {
                                        if (trans.ToNodeGuid == nodeTransition.ToNodeGuid && trans.FromNodeGuid == nodeTransition.FromNodeGuid)
                                            node.AddTransition(trans);
                                    }
                                }

                                // Overrides
                                count = node.OverrideTransitions.Count;
                                for (int i = 0; i < count; i++)
                                {
                                    var nodeTransition = node.OverrideTransitions[i];
                                    foreach (Transition trans in OverrideTransitions)
                                    {
                                        if (trans.ToNodeGuid == nodeTransition.ToNodeGuid && trans.FromNodeGuid == nodeTransition.FromNodeGuid)
                                            node.AddOverrideTransition(trans);
                                    }
                                }
                            }
                        }

                        if (LayersToNodes.Count > 0 && LayersToNodes[0].Count > 0)
                            RootNode = BaseFSMParser.LayersToNodes[0][0];

                        if (RootNode is not null)
                        {
                            int nIndex = 1;
                            BuildTree(RootNode, ref nIndex, 0, LayersToNodes, LayerToNonEmptyLayerIndices);
                        }
                    }
                    break;

                case "addAllTransition": // Adds override transitions (mainly intended for current to base fsm connections)
                    foreach (var elem2 in elem.Value.EnumerateObject())
                    {
                        if (elem2.NameEquals("EnableFalseTransition"))
                        {
                            _logger?.LogDebug("Unsupported 'EnableFalseTransition' in 'addAllTransition'");
                            HasErrors = true;
                        }
                        else if (elem2.NameEquals("Transition"))
                        {
                            Transition? transition = JsonSerializer.Deserialize<Transition>(elem2.Value, DefaultJsonSerializerOptions.InstanceForRead);
                            if (transition is null)
                            {
                                _logger?.LogError("Failed to deserialize Transition in 'addAllTransition'.");
                                HasErrors = true;
                                break;
                            }

                            foreach (List<FSMNode> layer in LayersToNodes)
                            {
                                foreach (FSMNode node in layer)
                                {
                                    if (node.Guid == transition.ToNodeGuid)
                                    {
                                        OverrideTransitions.Add(transition);
                                        node.AddOverrideTransition(transition);
                                    }
                                }
                            }
                        }
                        else
                        {
                            _logger?.LogError("Unsupported '{}' in 'addAllTransition'", elem2.Name);
                            HasErrors = true;
                        }
                    }

                    break;

                case "addTransition":  // Adds regular transitions (mainly intended for current to base fsm connections)
                    if (elem.Value.GetPropertyCount() != 0)
                    {
                        foreach (var trans in elem.Value.EnumerateObject())
                        {
                            Transition? transition = JsonSerializer.Deserialize<Transition>(trans.Value, DefaultJsonSerializerOptions.InstanceForRead);
                            if (transition is null)
                            {
                                _logger?.LogError("Failed to deserialize Transition in 'addTransition'.");
                                HasErrors = true;
                                break;
                            }

                            foreach (List<FSMNode> layer in LayersToNodes)
                            {
                                foreach (FSMNode node in layer)
                                {
                                    if (node.Guid == transition.ToNodeGuid)
                                    {
                                        NormalTransitions.Add(transition);
                                        node.AddTransition(transition);
                                    }
                                }
                            }
                        }
                    }
                    break;

                default:
                    // Anything else is a component
                    {

                        if (!ComponentNameToType.TryGetValue(elem.Name, out Type? componentType))
                        {
                            _logger?.LogError("Component '{name}' is not supported.", elem.Name);
                            HasErrors = true;
                            continue;
                        }

                        try
                        {
                            BehaviorTreeComponent? component = (BehaviorTreeComponent?)elem.Value.Deserialize(componentType, DefaultJsonSerializerOptions.InstanceForRead);
                            if (component is null)
                            {
                                _logger?.LogError("Failed to deserialize Component ({})", componentType.Name);
                                HasErrors = true;
                                break;
                            }

                            /* EnumString dumper
                            foreach (var prop in component.GetType().GetProperties().Where(e => e.PropertyType.Name == "EnumString"))
                            {
                                EnumString value = (EnumString)prop.GetValue(component);
                                if (value is null)
                                    continue;
                            
                                if (!_compToEnums.TryGetValue(elem.Name, out Dictionary<string, SortedDictionary<int, EnumString>> props))
                                {
                                    props = [];
                                    _compToEnums.Add(elem.Name, props);
                                }
                            
                                if (!props.TryGetValue(prop.Name, out SortedDictionary<int, EnumString> values))
                                {
                                    values = [];
                                    props.Add(prop.Name, values);
                                }
                            
                                values.TryAdd(value.Index, value);
                            }
                            */

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
                        catch (Exception ex)
                        {
                            _logger?.LogError("Component '{name}' errored: {ex}.", elem.Name, ex.Message);
                            HasErrors = true;
                            continue;
                        }
                    }
                    break;

            }
        }

        // Link transition condition guids to their components directly
        foreach (Transition transition in NormalTransitions)
        {
            foreach (uint conditionGuid in transition.ConditionGuids)
            {
                foreach (BehaviorTreeComponent component in Components)
                {
                    if (conditionGuid == component.Guid)
                    {
                        if (component is not ConditionComponent condComponent)
                            throw new InvalidDataException($"Component {component.ComponentName} ({conditionGuid}) was expected to be a ConditionComponent, but isn't");

                        // This isn't part of the game, but since we aren't creating a new component when importing a base fsm
                        // (the game would create a new component and copy its data over except for lists)
                        // We need to check if the component is already in the list, otherwise we will have duplicates
                        if (transition.ConditionComponents.Contains(condComponent))
                            continue;

                        transition.ConditionComponents.Add(condComponent);
                        break;
                    }
                }
            }
        }

        foreach (Transition transition in OverrideTransitions)
        {
            foreach (uint conditionGuid in transition.ConditionGuids)
            {
                foreach (BehaviorTreeComponent component in Components)
                {
                    if (conditionGuid == component.Guid)
                    {
                        if (component is not ConditionComponent condComponent)
                            throw new InvalidDataException($"Component {component.ComponentName} ({conditionGuid}) was expected to be a ConditionComponent, but isn't");

                        // (Same here.)
                        if (transition.ConditionComponents.Contains(condComponent))
                            continue;

                        transition.ConditionComponents.Add(condComponent);
                        break;
                    }
                }
            }
        }

        // Fsms can have nothing at all. See: ba7350_snd_1_fsm_ingame
        if (LayersToNodes.Count > 0 && LayersToNodes[0].Count > 0)
        {
            // TODO: Figure out sound fsm trees (& determine root) properly: i.e pl1100_snd_auto_base_1_fsm_ingame
            RootNode = LayersToNodes[0][0];
                
            int nIndex = 1;
            BuildTree(RootNode, ref nIndex, 0, LayersToNodes, LayerToNonEmptyLayerIndices);
        }
    }

    // Reversed - 41 57 41 56 41 55 41 54 56 57 55 53 48 83 EC ? 4C 89 CE 45 89 C6
    // NOTE (repeat): Groups are merely layers, but does not include layers with no nodes
    // Hence layerToGroupsIndices
    public static void BuildTree(FSMNode node, ref int nodeIndex, int layerIndex, List<List<FSMNode>> nodeLayers, List<int> layerIndexToLayerNumber)
    {
        // Non original, but added to keep track of nodes's layers
        node.LayerIndex = layerIndexToLayerNumber[layerIndex];

        int numNodesThisLayer = nodeIndex == 1 ? nodeLayers[layerIndex].Count - 1 : 0;
        if (node.ChildLayerId != -1 && nodeLayers.Count > 0)
        {
            int childLayerIndex = layerIndexToLayerNumber.IndexOf(node.ChildLayerId);
            if (childLayerIndex != -1)
            {
                List<FSMNode> layerNodes = nodeLayers[childLayerIndex];

                int nIndex = 1;
                node.Children.Add(layerNodes[0]);
                BuildTree(layerNodes[0], ref nIndex, childLayerIndex, nodeLayers, layerIndexToLayerNumber);
            }
        }

        for (int i = 0; i < numNodesThisLayer; i++)
        {
            List<FSMNode> nodesThisLayer = nodeLayers[layerIndex];
            if (i >= nodesThisLayer.Count)
                return;

            FSMNode childNode = nodesThisLayer[nodeIndex];
            node.Children.Add(childNode);
            nodeIndex++;

            BuildTree(childNode, ref nodeIndex, layerIndex, nodeLayers, layerIndexToLayerNumber);
        }
    }
}
