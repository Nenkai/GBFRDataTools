using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Base;

// ui::utility::EnumString
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EnumString
{
    [JsonPropertyName("str_")]
    public string Str { get; set; }

    [JsonPropertyName("index_")]
    public int Index { get; set; }
}
