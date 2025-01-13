using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Base;

public class ExEmVoiceActionNo_Param
{
    [JsonPropertyName("begin_")]
    public int Begin { get; set; }

    [JsonPropertyName("end_")]
    public int End { get; set; }

    [JsonPropertyName("overCondition_")]
    public int OverCondition { get; set; }

    [JsonPropertyName("value_")]
    public int Value { get; set; }

    public ExEmVoiceActionNo_Param()
    {
    }
}
