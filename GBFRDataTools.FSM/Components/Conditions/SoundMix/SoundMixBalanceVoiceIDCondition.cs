using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceVoiceIDCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceVoiceIDCondition);

    [JsonPropertyName("voiceEventID_")]
    public int VoiceEventID { get; set; } = 0;

    [JsonPropertyName("isCheckStart_")]
    public bool IsCheckStart { get; set; } = true;
}
