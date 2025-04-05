using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class CursorReset : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CursorReset);

    [JsonPropertyName("menuIDs_")]
    public BindingList<string> MenuIDs { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;
}
