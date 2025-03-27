using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class ActionNode : LeafNode
{
    [JsonPropertyName("param_")]
    public ActionNodeParam Param { get; set; }

}

public class ActionNodeParam : NodeParamBase
{
    [JsonPropertyName("uActionHashedKey_")]
    public uint ActionHashedKey { get; set; }

    [JsonPropertyName("iAttribute_")]
    public int Attribute { get; set; }

    [JsonPropertyName("AnySuccessMode_")]
    public bool AnySuccessMode { get; set; }
}
