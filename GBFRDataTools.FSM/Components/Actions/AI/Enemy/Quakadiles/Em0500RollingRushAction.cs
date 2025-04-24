using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500RollingRushAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500RollingRushAction);

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 3f; // Offset 0x1EC

    [JsonPropertyName("rushHomingAngle_")]
    public Vector4 RushHomingAngle { get; set; } = new Vector4(0.1f, 0.45f, 0.45f, 0.6f); // Offset 0x1F0

    [JsonPropertyName("turnHomingAngle_")]
    public float TurnHomingAngle { get; set; } = 5f; // Offset 0x200

    [JsonPropertyName("hoppingHomingAngle_")]
    public float HoppingHomingAngle { get; set; } = 10f; // Offset 0x204

    [JsonPropertyName("reflectionHomingMaxAngle_")]
    public float ReflectionHomingMaxAngle { get; set; } = 90f; // Offset 0x208

    [JsonPropertyName("maxSeconds_")]
    public float MaxSeconds { get; set; } = 10f; // Offset 0x20C

    [JsonPropertyName("turnSeconds_")]
    public float TurnSeconds { get; set; } = 3f; // Offset 0x210

    [JsonPropertyName("initialSpeed_")]
    public Vector4 InitialSpeed { get; set; } = new Vector4(11f, 14f, 14f, 17f); // Offset 0x220

    [JsonPropertyName("accel_")]
    public float Accel { get; set; } = 0.5f; // Offset 0x230

    [JsonPropertyName("hoppingAccel_")]
    public float HoppingAccel { get; set; } = 3f; // Offset 0x234

    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 40f; // Offset 0x238

    [JsonPropertyName("refrectAngle_")]
    public float RefrectAngle { get; set; } = 60f; // Offset 0x244

    [JsonPropertyName("driftBodyHormingAngle_")]
    public float DriftBodyHormingAngle { get; set; } = 5f; // Offset 0x248

    [JsonPropertyName("driftVectorHormingAngle_")]
    public float DriftVectorHormingAngle { get; set; } = 1f; // Offset 0x24C

    [JsonPropertyName("driftSpeedMag_")]
    public float DriftSpeedMag { get; set; } = 0.98f; // Offset 0x250

    [JsonPropertyName("driftTransSpeed_")]
    public float DriftTransSpeed { get; set; } = 10f; // Offset 0x254

    [JsonPropertyName("gashJumpWaitTime_")]
    public float GashJumpWaitTime { get; set; } = 1f; // Offset 0x258

    [JsonPropertyName("gashJumpTime_")]
    public float GashJumpTime { get; set; } = 2f; // Offset 0x25C

    [JsonPropertyName("gashJumpHeight_")]
    public float GashJumpHeight { get; set; } = 30f; // Offset 0x260

    [JsonPropertyName("gashTargetDistMax_")]
    public float GashTargetDistMax { get; set; } = 20f; // Offset 0x264

    [JsonPropertyName("gashTargetAngleMax_")]
    public float GashTargetAngleMax { get; set; } = 30f; // Offset 0x268

    [JsonPropertyName("gashBoundTimeRate_")]
    public float GashBoundTimeRate { get; set; } = 0.4f; // Offset 0x26C

    [JsonPropertyName("gashBoundHeightRate_")]
    public float GashBoundHeightRate { get; set; } = 0.3f; // Offset 0x270

    [JsonPropertyName("gashJumpCurve_")]
    public GuiImportableCurve<float> GashJumpCurve { get; set; } // Offset 0x278

    [JsonPropertyName("finalJumpTime_")]
    public float FinalJumpTime { get; set; } = 1f; // Offset 0x2A0

    [JsonPropertyName("finalJumpHomingAngle_")]
    public float FinalJumpHomingAngle { get; set; } = 2f; // Offset 0x2A4

    [JsonPropertyName("finalChargeAnimRate_")]
    public float FinalChargeAnimRate { get; set; } = 2.5f; // Offset 0x2A8

    [JsonPropertyName("finalChargeModelScale_")]
    public float FinalChargeModelScale { get; set; } = 1.2f; // Offset 0x2AC

    [JsonPropertyName("finalChargeHomingSpeed_")]
    public float FinalChargeHomingSpeed { get; set; } = 3.5f; // Offset 0x2B0

    [JsonPropertyName("finalChargeHomingAngleMax_")]
    public float FinalChargeHomingAngleMax { get; set; } = 120f; // Offset 0x2B4

    [JsonPropertyName("finalRushInitialSpeed_")]
    public float FinalRushInitialSpeed { get; set; } = 60f; // Offset 0x2B8

    [JsonPropertyName("finalRushAccel_")]
    public float FinalRushAccel { get; set; } = 1f; // Offset 0x2BC

    [JsonPropertyName("finalRushMaxSpeed_")]
    public float FinalRushMaxSpeed { get; set; } = 80f; // Offset 0x2C0

    [JsonPropertyName("finalRushTime_")]
    public float FinalRushTime { get; set; } = 2f; // Offset 0x2C4

    [JsonPropertyName("changeTarget_Hopping_")]
    public bool ChangeTarget_Hopping { get; set; } = true; // Offset 0x2C8

    [JsonPropertyName("changeTarget_Turn_")]
    public bool ChangeTarget_Turn { get; set; } = false; // Offset 0x2C9

    [JsonPropertyName("changeTarget_TurnAfterAttackHit_")]
    public bool ChangeTarget_TurnAfterAttackHit { get; set; } = true; // Offset 0x2CA

    [JsonPropertyName("changeTarget_GashJump_")]
    public bool ChangeTarget_GashJump { get; set; } = true; // Offset 0x2CB

    public Em0500RollingRushAction()
    {
    }
}


