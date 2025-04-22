using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class EaseParam
{
    [JsonPropertyName("category_")]
    public int Category { get; set; } // Offset 0x8

    [JsonPropertyName("calcType_")]
    public int CalcType { get; set; } // Offset 0xC

    public EaseParam()
    {
    }
}
