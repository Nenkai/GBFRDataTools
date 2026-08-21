using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.BehaviorTree;

public class RandomSelectorNode : CompositeNode
{
    [JsonPropertyName("param_")]
    public RandomSelectorNodeParam Param { get; set; } = new();
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class RandomSelectorNodeParam : NodeParamBase
{
    [JsonPropertyName("childNodeRatio0_")]
    public byte ChildNodeRatio0 { get; set; } 

    [JsonPropertyName("childNodeRatio1_")]
    public byte ChildNodeRatio1 { get; set; } 

    [JsonPropertyName("childNodeRatio2_")]
    public byte ChildNodeRatio2 { get; set; } 

    [JsonPropertyName("childNodeRatio3_")]
    public byte ChildNodeRatio3 { get; set; } 

    [JsonPropertyName("childNodeRatio4_")]
    public byte ChildNodeRatio4 { get; set; } 

    [JsonPropertyName("childNodeRatio5_")]
    public byte ChildNodeRatio5 { get; set; } 

    [JsonPropertyName("childNodeRatio6_")]
    public byte ChildNodeRatio6 { get; set; } 

    [JsonPropertyName("childNodeRatio7_")]
    public byte ChildNodeRatio7 { get; set; }
}
