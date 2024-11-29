using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class BaMagmaWaveSetParameterAction : ActionComponent
{
    [JsonPropertyName("animationId_")]
    public int AnimationId { get; set; } = 16;

    [JsonPropertyName("animationSpeed_")]
    public float AnimationSpeed { get; set; } = 1.0f;

    [JsonPropertyName("attackPower_")]
    public float AttackPower { get; set; } = 0.0f;
}
