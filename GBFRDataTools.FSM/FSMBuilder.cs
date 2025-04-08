using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Converters;
using GBFRDataTools.FSM.Components;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GBFRDataTools.FSM;

public class FSMSerializer
{
    public FSMState _state;

    private readonly List<BehaviorTreeComponent> _components = [];

    public FSMSerializer(FSMState fsmState)
    {
        _state = fsmState;
    }

    public void WriteJson(Stream stream)
    {
        var options = new JsonWriterOptions
        {
            Indented = true,
        };

        using var writer = new Utf8JsonWriter(stream, options);
        writer.WriteStartObject();

        writer.WritePropertyName("EditorSettings");
        JsonSerializer.Serialize(writer, _state.EditorSettings, DefaultJsonSerializerOptions.InstanceForWrite);

        foreach (var layer in _state.Layers)
            WriteLayer(writer, layer.Key, layer.Value);

        writer.WriteStartObject("addAllTransition"); writer.WriteEndObject();
        writer.WriteStartObject("addTransition"); writer.WriteEndObject();
        writer.WriteStartObject("EnableBaseTransition"); writer.WriteEndObject();
        writer.WriteStartObject("EnableBaseAllTransition"); writer.WriteEndObject();

        foreach (var component in _components)
        {
            writer.WritePropertyName(component.ComponentName);
            JsonSerializer.Serialize(writer, component, FSMParser.ComponentNameToType[component.ComponentName], DefaultJsonSerializerOptions.InstanceForWrite);
        }

        writer.WriteEndObject();
        writer.Flush();
    }

    private void WriteLayer(Utf8JsonWriter writer, int layerNumber, List<FSMNode> layerNodes)
    {
        writer.WriteNumber("layerNo", layerNumber);
        foreach (var node in layerNodes)
            WriteNode(writer, node);
    }

    private void WriteNode(Utf8JsonWriter writer, FSMNode node)
    {
        writer.WritePropertyName("FSMNode");
        JsonSerializer.Serialize<FSMNode>(writer, node, DefaultJsonSerializerOptions.InstanceForWrite);

        foreach (BehaviorTreeComponent component in node.ExecutionComponents)
        {
            _components.Add(component);
        }

        foreach (Transition transition in node.RegularTransitions)
        {
            writer.WritePropertyName("Transition");
            JsonSerializer.Serialize<Transition>(writer, transition, DefaultJsonSerializerOptions.InstanceForWrite);

            foreach (var comp in transition.ConditionComponents)
                _components.Add(comp);
        }

        foreach (Transition transition in node.OverrideTransitions)
        {
            writer.WritePropertyName("Transition");
            JsonSerializer.Serialize<Transition>(writer, transition, DefaultJsonSerializerOptions.InstanceForWrite);

            foreach (var comp in transition.ConditionComponents)
                _components.Add(comp);
        }
    }
}
