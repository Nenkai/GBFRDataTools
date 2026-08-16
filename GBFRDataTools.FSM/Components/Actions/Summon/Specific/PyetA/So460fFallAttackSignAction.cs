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
public class So460fFallAttackSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So460fFallAttackSignAction);

    [JsonPropertyName("fallPosNoTargetOffset_")]
    public Vector4 FallPosNoTargetOffset { get; set; } = new Vector4(0f, 0f, 5f, 1f);

    [JsonPropertyName("fallReadyTime_")]
    public float FallReadyTime { get; set; } = 0.2f;

    [JsonPropertyName("fallAttackSignOffsetY_")]
    public float FallAttackSignOffsetY { get; set; } = 0.2f;

    [JsonPropertyName("fallAttackSignRadius_")]
    public float FallAttackSignRadius { get; set; } = 15f;

    [JsonPropertyName("fallAttackSignSpeed_")]
    public float FallAttackSignSpeed { get; set; } = 20f;

    [JsonPropertyName("fallAttackSignHomingRate_")]
    public float FallAttackSignHomingRate { get; set; } = 0.15f;

    [JsonPropertyName("fallAttackSignHomingDistMin_")]
    public float FallAttackSignHomingDistMin { get; set; } = 0.1f;

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

    [JsonPropertyName("jumpStartMotFrame_")]
    public int JumpStartMotFrame { get; set; } = 23;

    [JsonPropertyName("lockOnCameraOffset_")]
    public Vector4 LockOnCameraOffset { get; set; } = new Vector4(0f, 0f, -3f, 1f);
}
