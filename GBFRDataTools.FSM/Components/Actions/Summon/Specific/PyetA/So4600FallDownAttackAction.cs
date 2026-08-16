using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.PyetA;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4600FallDownAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4600FallDownAttackAction);

    [JsonPropertyName("lockOnTurnRate_")]
    public float LockOnTurnRate { get; set; } = 0.2f;

    [JsonPropertyName("fallReadyTime_")]
    public float FallReadyTime { get; set; } = 1f;

    [JsonPropertyName("fallPosNoTargetOffset_")]
    public Vector4 FallPosNoTargetOffset { get; set; } = new Vector4(0f, 0f, 5f, 1f);

    [JsonPropertyName("fallAttackCameraOffset_")]
    public Vector4 FallAttackCameraOffset { get; set; } = new Vector4(0f, 7.5f, 0f, 1f);

    [JsonPropertyName("fallAttackCameraLength_")]
    public float FallAttackCameraLength { get; set; } = 20f;

    [JsonPropertyName("landingCameraSetTime_")]
    public float LandingCameraSetTime { get; set; } = 0f;

    [JsonPropertyName("landingCameraOffset_")]
    public Vector4 LandingCameraOffset { get; set; } = new Vector4(0f, 5f, 5f, 1f);

    [JsonPropertyName("landingCameraLength_")]
    public float LandingCameraLength { get; set; } = 5f;

    [JsonPropertyName("fallAttackSignOffsetY_")]
    public float FallAttackSignOffsetY { get; set; } = 0.2f;

    [JsonPropertyName("fallAttackSignRadius_")]
    public float FallAttackSignRadius { get; set; } = 15f;

    [JsonPropertyName("fallAttackSignSpeed_")]
    public float FallAttackSignSpeed { get; set; } = 25f;

    [JsonPropertyName("fallAttackSignHomingRate_")]
    public float FallAttackSignHomingRate { get; set; } = 0.15f;

    [JsonPropertyName("fallAttackSignHomingDistMin_")]
    public float FallAttackSignHomingDistMin { get; set; } = 0.1f;

    [JsonPropertyName("fallAttackSignAutoMoveTime_")]
    public float FallAttackSignAutoMoveTime { get; set; } = 0.1f;

    [JsonPropertyName("fallAttackSignCheckLineLength_")]
    public float FallAttackSignCheckLineLength { get; set; } = 0.8f;

    [JsonPropertyName("fallAttackSignCheckLineOffsetY_")]
    public float FallAttackSignCheckLineOffsetY { get; set; } = 1f;

    [JsonPropertyName("fallAttackSignCheckLineAdjustRate_")]
    public float FallAttackSignCheckLineAdjustRate { get; set; } = 0.5f;

    [JsonPropertyName("fallAttackPosGroundCheckHeight_")]
    public float FallAttackPosGroundCheckHeight { get; set; } = 1f;

    [JsonPropertyName("fallAttackPosGroundRotLimit_")]
    public float FallAttackPosGroundRotLimit { get; set; } = 50f;

    [JsonPropertyName("fallAttackSignControlDistMax_")]
    public float FallAttackSignControlDistMax { get; set; } = 60f;

    [JsonPropertyName("fallAttackJumpPower_")]
    public Vector2 FallAttackJumpPower { get; set; } = new Vector2(5f, 0.1f);

    [JsonPropertyName("fallAttackFallPower_")]
    public Vector2 FallAttackFallPower { get; set; } = new Vector2(-1f, 0.1f);

    [JsonPropertyName("fallAttackStaySwitchSpeed_")]
    public float FallAttackStaySwitchSpeed { get; set; } = 2f;

    [JsonPropertyName("fallAttackFallSwitchSpeed_")]
    public float FallAttackFallSwitchSpeed { get; set; } = -1f;

    [JsonPropertyName("fallAttackStayGravity_")]
    public float FallAttackStayGravity { get; set; } = 0.07f;

    [JsonPropertyName("fallAttackLandingTime_")]
    public float FallAttackLandingTime { get; set; } = 3f;

    [JsonPropertyName("followEndDist_")]
    public float FollowEndDist { get; set; } = 0.5f;

    [JsonPropertyName("lockOnCameraOffset_")]
    public Vector4 LockOnCameraOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("jumpStartMotFrame_")]
    public int JumpStartMotFrame { get; set; } = 23;

    [JsonPropertyName("useFallAttackSignLegacyLogic_")]
    public bool UseFallAttackSignLegacyLogic { get; set; } = false;
}
