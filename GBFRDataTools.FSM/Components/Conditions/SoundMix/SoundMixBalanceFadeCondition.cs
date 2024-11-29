using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceFadeCondition : ConditionComponent
{
    [JsonPropertyName("isSelectHandle_")]
    public bool IsSelectHandle { get; set; } = true;

    [JsonPropertyName("isSelectEventInOut_")]
    public bool IsSelectEventInOut { get; set; } = false;

    [JsonPropertyName("isSelectSceneJump_")]
    public bool IsSelectSceneJump { get; set; } = true;
}
