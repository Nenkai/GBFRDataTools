using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallReactionTalkEvent : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallReactionTalkEvent);

    [JsonPropertyName("targetId_")]
    public string TargetId { get; set; } // Offset 0x48

    [JsonPropertyName("reactionId_")]
    public string ReactionId { get; set; } // Offset 0x68

    [JsonPropertyName("delay_")]
    public float Delay { get; set; } = 0f; // Offset 0x88

    public CallReactionTalkEvent()
    {
    }
}
