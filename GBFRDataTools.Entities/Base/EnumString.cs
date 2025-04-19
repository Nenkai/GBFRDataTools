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
public class EnumString<T> where T : struct, Enum
{
    [Browsable(false)]
    [Description("Name of this enum field at the specified index. Generally unused.")]
    [JsonPropertyName("str_")]
    public string Str { get; set; }

    [Description("Enum value.")]
    [JsonPropertyName("index_")]
    public T Index { get; set; }
}
