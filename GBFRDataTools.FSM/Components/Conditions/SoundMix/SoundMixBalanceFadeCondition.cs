using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceFadeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceFadeCondition);

    [JsonPropertyName("isSelectHandle_")]
    public bool IsSelectHandle { get; set; } = true;

    [JsonPropertyName("isSelectEventInOut_")]
    public bool IsSelectEventInOut { get; set; } = false;

    [JsonPropertyName("isSelectSceneJump_")]
    public bool IsSelectSceneJump { get; set; } = true;
}
