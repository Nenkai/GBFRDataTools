using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class DebuffData
{
    [JsonPropertyName("category")]
    public int Category { get; set; } // Offset 0x8

    [JsonPropertyName("type")]
    public int Type { get; set; } // Offset 0xC

    [Description("""
        Time, in seconds for the debuff to be active. 
        Affected by masteries and resistances.
        """)]
    [JsonPropertyName("sec")]
    public float Sec { get; set; } // Offset 0x10

    [Description("""
        Value for the weight of a debuff to be applied. ie. 40% ATK DOWN instead of 20% ATK DOWN. 
        Debuffs that do not require a value will ignore this.
        """)]
    [JsonPropertyName("rate")]
    public float Rate { get; set; } // Offset 0x14

    public DebuffData()
    {
    }
}
