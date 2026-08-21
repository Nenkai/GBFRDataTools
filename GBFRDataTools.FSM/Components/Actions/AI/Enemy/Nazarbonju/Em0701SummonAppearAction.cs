using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0701SummonAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0701SummonAppearAction);

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 

    [JsonPropertyName("summonStartSeDefineName_")]
    public string? SummonStartSeDefineName { get; set; } 

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; } = false; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 1f; 

    [JsonPropertyName("moveToOffset_")]
    public Vector4 MoveToOffset { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("moveStartSec_")]
    public float MoveStartSec { get; set; } = 0f; 

    [JsonPropertyName("isAloneSummon_")]
    public bool IsAloneSummon { get; set; } = false; 

    [JsonPropertyName("summonWaitSec_")]
    public float SummonWaitSec { get; set; } = 1f; 

    [JsonPropertyName("summonAppearDelaySec_")]
    public float SummonAppearDelaySec { get; set; } = 0f; 

    [JsonPropertyName("isEnableLockOn_")]
    public bool IsEnableLockOn { get; set; } = true; 

    [JsonPropertyName("isEnableDamage_")]
    public bool IsEnableDamage { get; set; } = true; 

    [JsonPropertyName("forceCharge_")]
    public bool ForceCharge { get; set; } = false;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } = new();
}
