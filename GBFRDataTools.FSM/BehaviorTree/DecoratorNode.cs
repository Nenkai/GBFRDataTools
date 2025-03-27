using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class DecoratorNode : CompositeNode
{
    [JsonPropertyName("param_")]
    public DecorationNodeParam Param { get; set; }
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
}
