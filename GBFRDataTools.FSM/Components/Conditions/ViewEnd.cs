using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class ViewEnd : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ViewEnd);

    [JsonPropertyName("views_")]
    public BindingList<string> Views { get; set; } // Offset 0x38

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x50
}
