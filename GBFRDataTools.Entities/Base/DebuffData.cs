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

    [JsonPropertyName("sec")]
    public float Sec { get; set; } // Offset 0x10

    [JsonPropertyName("rate")]
    public float Rate { get; set; } // Offset 0x14

    public DebuffData()
    {
    }
}
