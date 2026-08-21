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
    public float StartHomingAngle { get; set; } = 3f; 

    [JsonPropertyName("rushHomingAngle_")]
    public Vector4 RushHomingAngle { get; set; } = new Vector4(0.1f, 0.45f, 0.45f, 0.6f); 

    [JsonPropertyName("turnHomingAngle_")]
    public float TurnHomingAngle { get; set; } = 5f; 

    [JsonPropertyName("hoppingHomingAngle_")]
    public float HoppingHomingAngle { get; set; } = 10f; 

    [JsonPropertyName("reflectionHomingMaxAngle_")]
    public float ReflectionHomingMaxAngle { get; set; } = 90f; 

    [JsonPropertyName("maxSeconds_")]
    public float MaxSeconds { get; set; } = 10f; 

    [JsonPropertyName("turnSeconds_")]
    public float TurnSeconds { get; set; } = 3f; 

    [JsonPropertyName("initialSpeed_")]
    public Vector4 InitialSpeed { get; set; } = new Vector4(11f, 14f, 14f, 17f); 

    [JsonPropertyName("accel_")]
    public float Accel { get; set; } = 0.5f; 

    [JsonPropertyName("hoppingAccel_")]
    public float HoppingAccel { get; set; } = 3f; 

    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 40f; 

    [JsonPropertyName("refrectAngle_")]
    public float RefrectAngle { get; set; } = 60f; 

    [JsonPropertyName("driftBodyHormingAngle_")]
    public float DriftBodyHormingAngle { get; set; } = 5f; 

    [JsonPropertyName("driftVectorHormingAngle_")]
    public float DriftVectorHormingAngle { get; set; } = 1f; 

    [JsonPropertyName("driftSpeedMag_")]
    public float DriftSpeedMag { get; set; } = 0.98f; 

    [JsonPropertyName("driftTransSpeed_")]
    public float DriftTransSpeed { get; set; } = 10f; 

    [JsonPropertyName("gashJumpWaitTime_")]
    public float GashJumpWaitTime { get; set; } = 1f; 

    [JsonPropertyName("gashJumpTime_")]
    public float GashJumpTime { get; set; } = 2f; 

    [JsonPropertyName("gashJumpHeight_")]
    public float GashJumpHeight { get; set; } = 30f; 

    [JsonPropertyName("gashTargetDistMax_")]
    public float GashTargetDistMax { get; set; } = 20f; 

    [JsonPropertyName("gashTargetAngleMax_")]
    public float GashTargetAngleMax { get; set; } = 30f; 

    [JsonPropertyName("gashBoundTimeRate_")]
    public float GashBoundTimeRate { get; set; } = 0.4f; 

    [JsonPropertyName("gashBoundHeightRate_")]
    public float GashBoundHeightRate { get; set; } = 0.3f;

    [JsonPropertyName("gashJumpCurve_")]
    public GuiImportableCurve<float> GashJumpCurve { get; set; } = new();

    [JsonPropertyName("finalJumpTime_")]
    public float FinalJumpTime { get; set; } = 1f; 

    [JsonPropertyName("finalJumpHomingAngle_")]
    public float FinalJumpHomingAngle { get; set; } = 2f; 

    [JsonPropertyName("finalChargeAnimRate_")]
    public float FinalChargeAnimRate { get; set; } = 2.5f; 

    [JsonPropertyName("finalChargeModelScale_")]
    public float FinalChargeModelScale { get; set; } = 1.2f; 

    [JsonPropertyName("finalChargeHomingSpeed_")]
    public float FinalChargeHomingSpeed { get; set; } = 3.5f; 

    [JsonPropertyName("finalChargeHomingAngleMax_")]
    public float FinalChargeHomingAngleMax { get; set; } = 120f; 

    [JsonPropertyName("finalRushInitialSpeed_")]
    public float FinalRushInitialSpeed { get; set; } = 60f; 

    [JsonPropertyName("finalRushAccel_")]
    public float FinalRushAccel { get; set; } = 1f; 

    [JsonPropertyName("finalRushMaxSpeed_")]
    public float FinalRushMaxSpeed { get; set; } = 80f; 

    [JsonPropertyName("finalRushTime_")]
    public float FinalRushTime { get; set; } = 2f; 

    [JsonPropertyName("changeTarget_Hopping_")]
    public bool ChangeTarget_Hopping { get; set; } = true; 

    [JsonPropertyName("changeTarget_Turn_")]
    public bool ChangeTarget_Turn { get; set; } = false; 

    [JsonPropertyName("changeTarget_TurnAfterAttackHit_")]
    public bool ChangeTarget_TurnAfterAttackHit { get; set; } = true; 

    [JsonPropertyName("changeTarget_GashJump_")]
    public bool ChangeTarget_GashJump { get; set; } = true; 
}


