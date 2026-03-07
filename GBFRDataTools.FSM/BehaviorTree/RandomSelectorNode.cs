using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class RandomSelectorNode : CompositeNode
{
    [JsonPropertyName("param_")]
    public RandomSelectorNodeParam Param { get; set; } // Offset 0xE8
}


public class RandomSelectorNodeParam : NodeParamBase
{
    [JsonPropertyName("childNodeRatio0_")]
    public byte ChildNodeRatio0 { get; set; } // Offset 0x8

    [JsonPropertyName("childNodeRatio1_")]
    public byte ChildNodeRatio1 { get; set; } // Offset 0x9

    [JsonPropertyName("childNodeRatio2_")]
    public byte ChildNodeRatio2 { get; set; } // Offset 0xA

    [JsonPropertyName("childNodeRatio3_")]
    public byte ChildNodeRatio3 { get; set; } // Offset 0xB

    [JsonPropertyName("childNodeRatio4_")]
    public byte ChildNodeRatio4 { get; set; } // Offset 0xC

    [JsonPropertyName("childNodeRatio5_")]
    public byte ChildNodeRatio5 { get; set; } // Offset 0xD

    [JsonPropertyName("childNodeRatio6_")]
    public byte ChildNodeRatio6 { get; set; } // Offset 0xE

    [JsonPropertyName("childNodeRatio7_")]
    public byte ChildNodeRatio7 { get; set; } // Offset 0xF

    public RandomSelectorNodeParam()
    {
    }
}
