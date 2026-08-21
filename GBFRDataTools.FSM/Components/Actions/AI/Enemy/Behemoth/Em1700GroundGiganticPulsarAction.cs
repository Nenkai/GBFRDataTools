using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700GroundGiganticPulsarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700GroundGiganticPulsarAction);

    [JsonPropertyName("animMovementRate_")]
    public float AnimMovementRate { get; set; } = 1f;

    [JsonPropertyName("isCrossSmallShot_")]
    public bool IsCrossSmallShot { get; set; } = false;

    [JsonPropertyName("offsetDist_")]
    public Vector4 OffsetDist { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotScale_")]
    public Vector4 ShotScale { get; set; } = Vector4.UnitW;

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; } = 0.5f;
}
