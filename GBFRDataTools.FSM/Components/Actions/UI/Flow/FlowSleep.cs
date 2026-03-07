using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Flow;

public class FlowSleep : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FlowSleep);

    [JsonPropertyName("fsmNames_")]
    public BindingList<string> FsmNames { get; set; } = []; // Offset 0x30

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x48

    public FlowSleep()
    {
    }
}
