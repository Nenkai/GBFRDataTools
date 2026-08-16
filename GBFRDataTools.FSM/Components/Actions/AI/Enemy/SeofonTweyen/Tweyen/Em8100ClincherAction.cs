using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100ClincherAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100ClincherAction);

    [JsonPropertyName("isUseSecondShot_")]
    public bool IsUseSecondShot { get; set; } = false;

    [JsonPropertyName("isReturnAttackMode_")]
    public bool IsReturnAttackMode { get; set; } = false;

    [JsonPropertyName("isSkillNameCallVoice_")]
    public bool IsSkillNameCallVoice { get; set; } = true;

    [JsonPropertyName("isUseSkillNameLabel_")]
    public bool IsUseSkillNameLabel { get; set; } = true;

    [JsonPropertyName("isGroundShot_")]
    public bool IsGroundShot { get; set; } = false;

    [JsonPropertyName("isBurstCounter")]
    public bool IsBurstCounter { get; set; } = false;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "20a0";

    [JsonPropertyName("attackSignIntervalSec_")]
    public float AttackSignIntervalSec { get; set; } = 1f;

    [JsonPropertyName("attackSign2ndIntervalSec_")]
    public float AttackSign2ndIntervalSec { get; set; } = 1f;

    [JsonPropertyName("attackSignLength_")]
    public float AttackSignLength { get; set; } = 100f;

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = -0.06f;

    [JsonPropertyName("heightInterpFrameByLanding_")]
    public int HeightInterpFrameByLanding { get; set; } = 120;

    [JsonPropertyName("groundShotTurnMaxDeg_")]
    public float GroundShotTurnMaxDeg { get; set; } = 2.5f;

    [JsonPropertyName("turnToTargetRate_")]
    public float TurnToTargetRate { get; set; } = 0.03f;

    [JsonPropertyName("turnToTargetTime_")]
    public float TurnToTargetTime { get; set; } = 4.5f;

    [JsonPropertyName("singleTargetRandValue_")]
    public int SingleTargetRandValue { get; set; } = 3;
}