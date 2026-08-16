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
public class Em8100WideShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100WideShotAction);

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0;

    [JsonPropertyName("actionEndTimingFrame_")]
    public int ActionEndTimingFrame { get; set; } = 0;

    [JsonPropertyName("attackSignSize_")]
    public float AttackSignSize { get; set; } = 5f;

    [JsonPropertyName("attackSignFrame_")]
    public float AttackSignFrame { get; set; } = 40f;

    [JsonPropertyName("shotRotX_")]
    public float ShotRotX { get; set; } = 60f;

    [JsonPropertyName("shotStartPosOffsetY_")]
    public float ShotStartPosOffsetY { get; set; } = 0f;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; }

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "wide_shot";

    [JsonPropertyName("spinShotFsmName_")]
    public string SpinShotFsmName { get; set; } = "wheel_of_death";

    [JsonPropertyName("shotIntervalFrame_")]
    public int ShotIntervalFrame { get; set; } = 2;

    [JsonPropertyName("shotStartRotY_")]
    public float ShotStartRotY { get; set; } = 0f;

    [JsonPropertyName("shotStepRotY_")]
    public float ShotStepRotY { get; set; } = 3f;

    [JsonPropertyName("shotOnceBulletNum_")]
    public int ShotOnceBulletNum { get; set; } = 2;

    [JsonPropertyName("shotTotalFrame_")]
    public int ShotTotalFrame { get; set; } = 30;

    [JsonPropertyName("spinShotNum_")]
    public int SpinShotNum { get; set; } = 30;

    [JsonPropertyName("spinShotStartRotX_")]
    public float SpinShotStartRotX { get; set; } = 20f;

    [JsonPropertyName("spinShotAddRotX_")]
    public float SpinShotAddRotX { get; set; } = -1f;

    [JsonPropertyName("spinShotAddRotY_")]
    public float SpinShotAddRotY { get; set; } = 10f;

    [JsonPropertyName("spinShotStartRotY_")]
    public float SpinShotStartRotY { get; set; } = 10f;

    [JsonPropertyName("spinShotAttackSignDelaySec_")]
    public float SpinShotAttackSignDelaySec { get; set; } = 1.5f;

    [JsonPropertyName("spinShotAttackSignFrame_")]
    public int SpinShotAttackSignFrame { get; set; } = 40;

    [JsonPropertyName("spinShotOnceBulletNum_")]
    public int SpinShotOnceBulletNum { get; set; } = 3;
}