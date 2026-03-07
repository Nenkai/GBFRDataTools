using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Entities;

// BT::EaseParam
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EaseParam
{
    [JsonPropertyName("category_")]
    public int Category { get; set; } = -1;

    [JsonPropertyName("calcType_")]
    public int CalcType { get; set; } = -1;
}
