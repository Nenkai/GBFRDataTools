using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSetListenerAction : ActionComponent
{
    [JsonPropertyName("isEndTrigger_")]
    public bool IsEndTrigger { get; set; } = false;

    [JsonPropertyName("presetNo_")]
    public int PresetNo { get; set; } = 0;

    [JsonPropertyName("fadeSec_")]
    public float FadeSec { get; set; } = 0.0f;

}
