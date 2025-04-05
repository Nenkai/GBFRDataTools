using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class Guide : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Guide);

    [JsonPropertyName("guides_")]
    public BindingList<string> Guides { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("footer_")]
    public EnumString Footer { get; set; } = new();

    [JsonPropertyName("isFixAdd_")]
    public bool IsFixAdd { get; set; } = true;
}
