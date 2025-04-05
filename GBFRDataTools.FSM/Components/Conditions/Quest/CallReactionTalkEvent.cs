using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CallReactionTalkEvent : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallReactionTalkEvent);

    [JsonPropertyName("targetId_")]
    public string TargetId { get; set; } = string.Empty;

    [JsonPropertyName("reactionId_")]
    public string ReactionId { get; set; } = string.Empty;

    [JsonPropertyName("delay_")]
    public float Delay { get; set; } = 0;
}
