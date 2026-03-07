using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndEvent : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndEvent);

    [JsonPropertyName("eventNo_")]
    public int EventNo { get; set; } = 0;

    [JsonPropertyName("eventType_")]
    public EventType EventType { get; set; } = 0;

    public override string ToString()
    {
        return $"End {EventType}{EventNo:D4}";
    }
}
