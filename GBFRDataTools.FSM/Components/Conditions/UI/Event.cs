using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

[Description("Checks for a specific UI event returned by an action.")]
public class Event : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Event);

    [JsonPropertyName("event_")]
    public string Event_ { get; set; } = string.Empty;

    [JsonPropertyName("any_")]
    public bool Any { get; set; } = false;

    [JsonPropertyName("open_")]
    public string Open { get; set; } = string.Empty;

    [JsonPropertyName("close_")]
    public string Close { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{ComponentName}({Event_})";
    }
}
