using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndEvent : QuestConditionComponent
{
    [JsonPropertyName("eventNo_")]
    public int EventNo { get; set; } = 0;

    [JsonPropertyName("eventType_")]
    public int EventType { get; set; } = 0;
}
