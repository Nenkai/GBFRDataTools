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
    public string Event_ { get; set; }

    [JsonPropertyName("any_")]
    public bool Any { get; set; }

    [JsonPropertyName("open_")]
    public string Open { get; set; }

    [JsonPropertyName("close_")]
    public string Close { get; set; }

    public override string ToString()
    {
        return $"{ComponentName}({Event_})";
    }
}
