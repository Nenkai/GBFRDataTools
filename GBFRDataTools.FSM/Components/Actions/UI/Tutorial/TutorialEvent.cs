using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.UI.Shop;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class TutorialEvent : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TutorialEvent);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("event_")]
    public string Event { get; set; } = string.Empty;
}
