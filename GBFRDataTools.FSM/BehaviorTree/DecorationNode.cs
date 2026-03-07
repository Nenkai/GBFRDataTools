using GBFRDataTools.FSM.Components;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class DecorationNode : CompositeNode
{
    [JsonPropertyName("param_")]
    public DecorationNodeParam Param { get; set; }

    public List<BehaviorTreeComponent> BehaviorTreeComponent { get; set; } = [];
}

public class DecorationNodeParam : NodeParamBase
{
    [JsonPropertyName("uConditionHashedKey_")]
    public uint ConditionHashedKey { get; set; }

    [JsonPropertyName("fAttribute_")]
    public float Attribute { get; set; }

    [JsonPropertyName("bIsResultNegated_")]
    public bool IsResultNegated { get; set; }

    [JsonPropertyName("once_")]
    public bool Once { get; set; }

    [JsonPropertyName("AnySuccessMode_")]
    public bool AnySuccessMode { get; set; }

    [JsonPropertyName("abortType_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public int AbortType { get; set; }
}
