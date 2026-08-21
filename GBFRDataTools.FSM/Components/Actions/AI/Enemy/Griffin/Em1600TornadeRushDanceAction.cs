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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600TornadeRushDanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600TornadeRushDanceAction);

    [JsonPropertyName("inhaleRateCenter_")]
    public float InhaleRateCenter { get; set; } = 11.5f; 

    [JsonPropertyName("riseTornadoNum_")]
    public int RiseTornadoNum { get; set; } = 5; 

    [JsonPropertyName("rushNum_")]
    public int RushNum { get; set; } = 3; 

    [JsonPropertyName("wingLandingTime_")]
    public float WingLandingTime { get; set; } = 2f; 

    [JsonPropertyName("wingEffectWaitTime_")]
    public float WingEffectWaitTime { get; set; } = 1f; 

    [JsonPropertyName("wingCollisionRadius_")]
    public float WingCollisionRadius { get; set; } = 2f; 

    [JsonPropertyName("rushRestartMovementRate_")]
    public float RushRestartMovementRate { get; set; } = 1f; 

    [JsonPropertyName("riseFinishMovementRate_")]
    public float RiseFinishMovementRate { get; set; } = 1f; 

    [JsonPropertyName("tornadoFanRot_")]
    public float TornadoFanRot { get; set; } = 120f; 

    [JsonPropertyName("createFeatherNum_")]
    public int CreateFeatherNum { get; set; } = 3; 

    [JsonPropertyName("createIntervalTime_")]
    public float CreateIntervalTime { get; set; } = 2f; 

    [JsonPropertyName("tornadoAttackRadius_")]
    public float TornadoAttackRadius { get; set; } = 12f; 

    [JsonPropertyName("inhaleRateInside_")]
    public float InhaleRateInside { get; set; } = 10f; 

    [JsonPropertyName("inhaleRateOutside_")]
    public float InhaleRateOutside { get; set; } = 20f; 

    [JsonPropertyName("inhaleRateDamaged_")]
    public float InhaleRateDamaged { get; set; } = 20f; 

    [JsonPropertyName("inhaleRadiusInside_")]
    public float InhaleRadiusInside { get; set; } = 13f; 

    [JsonPropertyName("inhaleRadiusCenter_")]
    public float InhaleRadiusCenter { get; set; } = 30f; 

    [JsonPropertyName("inhaleRadiuseOutside_")]
    public float InhaleRadiuseOutside { get; set; } = 100f; 

    [JsonPropertyName("isHalfFeatherNum_")]
    public bool IsHalfFeatherNum { get; set; } = false; 

    [JsonPropertyName("lineSignOffsetDist_")]
    public float LineSignOffsetDist { get; set; } = 5f; 

    [JsonPropertyName("maxRushTime_")]
    public float MaxRushTime { get; set; } = 1f; 

    [JsonPropertyName("rushMovementRate_")]
    public float RushMovementRate { get; set; } = 1f; 

    [JsonPropertyName("centerTornadoClearHitTime_")]
    public float CenterTornadoClearHitTime { get; set; } = 1f; 

    [JsonPropertyName("smallTornadoOffset1_1_")]
    public Vector4 SmallTornadoOffset1_1 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset1_2_")]
    public Vector4 SmallTornadoOffset1_2 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset1_3_")]
    public Vector4 SmallTornadoOffset1_3 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset2_1_")]
    public Vector4 SmallTornadoOffset2_1 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset2_2_")]
    public Vector4 SmallTornadoOffset2_2 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset2_3_")]
    public Vector4 SmallTornadoOffset2_3 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset3_1_")]
    public Vector4 SmallTornadoOffset3_1 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset3_2_")]
    public Vector4 SmallTornadoOffset3_2 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset3_3_")]
    public Vector4 SmallTornadoOffset3_3 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset4_1_")]
    public Vector4 SmallTornadoOffset4_1 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset4_2_")]
    public Vector4 SmallTornadoOffset4_2 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("smallTornadoOffset4_3_")]
    public Vector4 SmallTornadoOffset4_3 { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("extrudeRate_")]
    public float ExtrudeRate { get; set; } = 10f; 

    [JsonPropertyName("extrudeRadius_")]
    public float ExtrudeRadius { get; set; } = 10f; 

    [JsonPropertyName("checkTornadoDist_")]
    public float CheckTornadoDist { get; set; } = 3f; 
}


