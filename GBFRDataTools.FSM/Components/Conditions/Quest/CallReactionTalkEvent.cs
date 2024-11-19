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

public class CallReactionTalkEvent : QuestConditionComponent
{
    [JsonPropertyName("targetId_")]
    public string TargetId { get; set; }

    [JsonPropertyName("reactionId_")]
    public string ReactionId { get; set; }

    [JsonPropertyName("delay_")]
    public float Delay { get; set; }
}
