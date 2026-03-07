using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0000PlayEm7200VoiceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Np0000PlayEm7200VoiceAction);

    [JsonPropertyName("voiceNo_")]
    public int VoiceNo { get; set; } = 0;
}
