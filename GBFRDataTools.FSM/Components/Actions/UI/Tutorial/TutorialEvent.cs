using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class TutorialEvent : ActionComponent
{
    [JsonPropertyName("count_")]
    public int Count { get; set; }

    [JsonPropertyName("event_")]
    public string Event { get; set; }
}
