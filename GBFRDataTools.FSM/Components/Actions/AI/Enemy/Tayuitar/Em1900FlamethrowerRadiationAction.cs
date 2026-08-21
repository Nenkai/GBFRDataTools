using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900FlamethrowerRadiationAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900FlamethrowerRadiationAction);

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 5f; 

    [JsonPropertyName("isUseLeftArm_")]
    public bool IsUseLeftArm { get; set; } = true; 

    [JsonPropertyName("isUseRightArm_")]
    public bool IsUseRightArm { get; set; } = true; 

    [JsonPropertyName("embersTime_")]
    public float EmbersTime { get; set; } = 0.5f; 

    [JsonPropertyName("radiationIntervalFrame_")]
    public int RadiationIntervalFrame { get; set; } = 5; 

    [JsonPropertyName("maxEmbersNum_")]
    public int MaxEmbersNum { get; set; } = 5; 

    [JsonPropertyName("armAngle_")]
    public float ArmAngle { get; set; } = 35f;
}