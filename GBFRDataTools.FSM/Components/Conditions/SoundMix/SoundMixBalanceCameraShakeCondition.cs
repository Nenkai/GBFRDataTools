using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceCameraShakeCondition : ConditionComponent
{
    [JsonPropertyName("operatorType_")]
    public SoundMixBalanceCameraShakeConditionOperatorType OperatorType { get; set; } = 0;

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0;
}