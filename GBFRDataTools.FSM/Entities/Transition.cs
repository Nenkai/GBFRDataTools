using GBFRDataTools.FSM.Components;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BTInGame::Transition
public class Transition
{
    [JsonPropertyName("conditionGuid_")]
    public uint ConditionGuid { get; set; }

    [JsonPropertyName("conditionGuids_")]
    public BindingList<uint> ConditionGuids { get; set; } = []; // std::vector<unsigned int>

    // Did they mix up to and from? from is always as the target node.

    /// <summary>
    /// to = FROM aka SOURCE NODE, it's reversed
    /// </summary>
    [JsonPropertyName("toNodeGuid_")]
    public uint ToNodeGuid { get; set; }

    /// <summary>
    /// From = TO aka TARGET NODE, it's reversed
    /// </summary>
    [JsonPropertyName("fromNodeGuid_")]
    public uint FromNodeGuid { get; set; }

    /// <summary>
    /// Marks the transition as pointing to a node that ends the layer (or FSM?) <br/>
    /// Node is not physically present in the FSM file, but implied to exist at least.
    /// </summary>
    [JsonPropertyName("isEndTransition_")]
    public bool IsEndTransition { get; set; }

    /// <summary>
    /// Marks the transition as pointing to a node that ends the layer (or FSM?) <br/>
    /// Node is not physically present in the FSM file, but implied to exist at least.
    /// </summary>
    [JsonPropertyName("isFailedTransition_")]
    public bool IsFailedTransition { get; set; }

    [JsonPropertyName("params_")]
    public BindingList<TransitionParam> TransitionParams { get; set; } = [];

    [JsonIgnore]
    public List<ConditionComponent> ConditionComponents { get; set; } = [];

    public Transition(uint toNodeGuid, uint fromNodeGuid)
    {
        ToNodeGuid = toNodeGuid;
        FromNodeGuid = fromNodeGuid;
    }

    // Emulation
    public bool Execute(int unk)
    {
        return true;
    }

    public class TransitionParam // std::vector<BTInGame::Transition::TransitionParam
    {
        [JsonPropertyName("isAndCondition_")]
        public bool IsAndCondition { get; set; }

        [JsonPropertyName("priority_")]
        public int Priority { get; set; }
    }
}