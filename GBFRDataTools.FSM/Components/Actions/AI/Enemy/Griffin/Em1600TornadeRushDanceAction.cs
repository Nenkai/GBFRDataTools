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
    public float InhaleRateCenter { get; set; } = 11.5f; // Offset 0x2E0

    [JsonPropertyName("riseTornadoNum_")]
    public int RiseTornadoNum { get; set; } = 5; // Offset 0x2B0

    [JsonPropertyName("rushNum_")]
    public int RushNum { get; set; } = 3; // Offset 0x2B4

    [JsonPropertyName("wingLandingTime_")]
    public float WingLandingTime { get; set; } = 2f; // Offset 0x2B8

    [JsonPropertyName("wingEffectWaitTime_")]
    public float WingEffectWaitTime { get; set; } = 1f; // Offset 0x2BC

    [JsonPropertyName("wingCollisionRadius_")]
    public float WingCollisionRadius { get; set; } = 2f; // Offset 0x2C0

    [JsonPropertyName("rushRestartMovementRate_")]
    public float RushRestartMovementRate { get; set; } = 1f; // Offset 0x2C4

    [JsonPropertyName("riseFinishMovementRate_")]
    public float RiseFinishMovementRate { get; set; } = 1f; // Offset 0x2C8

    [JsonPropertyName("tornadoFanRot_")]
    public float TornadoFanRot { get; set; } = 120f; // Offset 0x2CC

    [JsonPropertyName("createFeatherNum_")]
    public int CreateFeatherNum { get; set; } = 3; // Offset 0x2D0

    [JsonPropertyName("createIntervalTime_")]
    public float CreateIntervalTime { get; set; } = 2f; // Offset 0x2D4

    [JsonPropertyName("tornadoAttackRadius_")]
    public float TornadoAttackRadius { get; set; } = 12f; // Offset 0x2D8

    [JsonPropertyName("inhaleRateInside_")]
    public float InhaleRateInside { get; set; } = 10f; // Offset 0x2DC

    [JsonPropertyName("inhaleRateOutside_")]
    public float InhaleRateOutside { get; set; } = 20f; // Offset 0x2E4

    [JsonPropertyName("inhaleRateDamaged_")]
    public float InhaleRateDamaged { get; set; } = 20f; // Offset 0x2E8

    [JsonPropertyName("inhaleRadiusInside_")]
    public float InhaleRadiusInside { get; set; } = 13f; // Offset 0x2EC

    [JsonPropertyName("inhaleRadiusCenter_")]
    public float InhaleRadiusCenter { get; set; } = 30f; // Offset 0x2F0

    [JsonPropertyName("inhaleRadiuseOutside_")]
    public float InhaleRadiuseOutside { get; set; } = 100f; // Offset 0x2F4

    [JsonPropertyName("isHalfFeatherNum_")]
    public bool IsHalfFeatherNum { get; set; } = false; // Offset 0x308

    [JsonPropertyName("lineSignOffsetDist_")]
    public float LineSignOffsetDist { get; set; } = 5f; // Offset 0x2F8

    [JsonPropertyName("maxRushTime_")]
    public float MaxRushTime { get; set; } = 1f; // Offset 0x2FC

    [JsonPropertyName("rushMovementRate_")]
    public float RushMovementRate { get; set; } = 1f; // Offset 0x300

    [JsonPropertyName("centerTornadoClearHitTime_")]
    public float CenterTornadoClearHitTime { get; set; } = 1f; // Offset 0x304

    [JsonPropertyName("smallTornadoOffset1_1_")]
    public Vector4 SmallTornadoOffset1_1 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x310

    [JsonPropertyName("smallTornadoOffset1_2_")]
    public Vector4 SmallTornadoOffset1_2 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x320

    [JsonPropertyName("smallTornadoOffset1_3_")]
    public Vector4 SmallTornadoOffset1_3 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x330

    [JsonPropertyName("smallTornadoOffset2_1_")]
    public Vector4 SmallTornadoOffset2_1 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x340

    [JsonPropertyName("smallTornadoOffset2_2_")]
    public Vector4 SmallTornadoOffset2_2 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x350

    [JsonPropertyName("smallTornadoOffset2_3_")]
    public Vector4 SmallTornadoOffset2_3 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x360

    [JsonPropertyName("smallTornadoOffset3_1_")]
    public Vector4 SmallTornadoOffset3_1 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x370

    [JsonPropertyName("smallTornadoOffset3_2_")]
    public Vector4 SmallTornadoOffset3_2 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x380

    [JsonPropertyName("smallTornadoOffset3_3_")]
    public Vector4 SmallTornadoOffset3_3 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x390

    [JsonPropertyName("smallTornadoOffset4_1_")]
    public Vector4 SmallTornadoOffset4_1 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x3A0

    [JsonPropertyName("smallTornadoOffset4_2_")]
    public Vector4 SmallTornadoOffset4_2 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x3B0

    [JsonPropertyName("smallTornadoOffset4_3_")]
    public Vector4 SmallTornadoOffset4_3 { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x3C0

    [JsonPropertyName("extrudeRate_")]
    public float ExtrudeRate { get; set; } = 10f; // Offset 0x3D0

    [JsonPropertyName("extrudeRadius_")]
    public float ExtrudeRadius { get; set; } = 10f; // Offset 0x3D4

    [JsonPropertyName("checkTornadoDist_")]
    public float CheckTornadoDist { get; set; } = 3f; // Offset 0x3D8

    public Em1600TornadeRushDanceAction()
    {
    }
}


