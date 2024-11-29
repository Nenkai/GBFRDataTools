using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class Event : ConditionComponent
{
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
