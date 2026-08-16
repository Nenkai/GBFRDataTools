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
public class Em8100AroundShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100AroundShotAction);

    [JsonPropertyName("isOneShotMotion_")]
    public bool IsOneShotMotion { get; set; } = false;

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("attackSignSize_")]
    public float AttackSignSize { get; set; } = 5f;

    [JsonPropertyName("attackSignFrame_")]
    public float AttackSignFrame { get; set; } = 40f;

    [JsonPropertyName("shotRotX_")]
    public float ShotRotX { get; set; } = 60f;

    [JsonPropertyName("minRotX_")]
    public float MinRotX { get; set; } = 7f;

    [JsonPropertyName("subRotX_")]
    public float SubRotX { get; set; } = 3f;

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "";

    [JsonPropertyName("motionLoopTimeSec_")]
    public float MotionLoopTimeSec { get; set; } = 1f;

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "around_shot";

    [JsonPropertyName("shotBulletNum_")]
    public int ShotBulletNum { get; set; } = 30;

    [JsonPropertyName("shotRotXAddStartTimingNum_")]
    public int ShotRotXAddStartTimingNum { get; set; } = 15;

    [JsonPropertyName("shotStepRotY_")]
    public float ShotStepRotY { get; set; } = 3f;
}