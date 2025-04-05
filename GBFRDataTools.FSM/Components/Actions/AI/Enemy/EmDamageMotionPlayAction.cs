using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDamageMotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageMotionPlayAction);

    [JsonPropertyName("animId_")]
    public string AnimId { get; set; } = "0000";

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = -1.0f;

    [JsonPropertyName("animMoveRateXZ_")]
    public float AnimMoveRateXZ { get; set; } = 1.0f;

    [JsonPropertyName("animMoveRateY_")]
    public float AnimMoveRateY { get; set; } = 1.0f;

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; } = 0.0f;

    [JsonPropertyName("animSpeedStep_")]
    public int AnimSpeedStep { get; set; } = 0;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 0.0f;

    [JsonPropertyName("gravityRateStep_")]
    public int GravityRateStep { get; set; } = 0;
}
