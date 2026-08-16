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
public class Em8100SideStepShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100SideStepShotAction);

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "step_shot_s";

    [JsonPropertyName("powerUpShotFsmName_")]
    public string PowerUpShotFsmName { get; set; } = "step_shot_curve";

    [JsonPropertyName("isLeftSideSetting_")]
    public bool IsLeftSideSetting { get; set; } = false;

    [JsonPropertyName("isSingleShot_")]
    public bool IsSingleShot { get; set; } = false;

    [JsonPropertyName("motionMoveRateByOverDrive_")]
    public float MotionMoveRateByOverDrive { get; set; } = 1.8f;

    [JsonPropertyName("distanceForCloseRange_")]
    public float DistanceForCloseRange { get; set; } = 10f;

    [JsonPropertyName("attackSignWidth_")]
    public float AttackSignWidth { get; set; } = 5f;

    [JsonPropertyName("attackSignRot_")]
    public float AttackSignRot { get; set; } = 0.7853982f;

    [JsonPropertyName("lineAttackSignFrame1stShot_")]
    public int LineAttackSignFrame1stShot { get; set; } = 35;

    [JsonPropertyName("lineAttackSignFrame2ndShot_")]
    public int LineAttackSignFrame2ndShot { get; set; } = 42;

    [JsonPropertyName("attackSignFramePowUp_")]
    public int AttackSignFramePowUp { get; set; } = 45;

    [JsonPropertyName("addShotNumByPowerUpMode_")]
    public int AddShotNumByPowerUpMode { get; set; } = 2;

    [JsonPropertyName("shotIntervalFrame_")]
    public int ShotIntervalFrame { get; set; } = 10;

    [JsonPropertyName("followArrowShotNum_")]
    public int FollowArrowShotNum { get; set; } = 5;

    [JsonPropertyName("followArrowShotStartIntervalFrame_")]
    public int FollowArrowShotStartIntervalFrame { get; set; } = 20;

    [JsonPropertyName("followArrowShotRapidIntervalFrame_")]
    public int FollowArrowShotRapidIntervalFrame { get; set; } = 5;

    [JsonPropertyName("powerUpShotOffsetPos_")]
    public Vector4 PowerUpShotOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("powerUpShotOffsetRotY_")]
    public float PowerUpShotOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("powerUpShotSecondOffsetRotY_")]
    public float PowerUpShotSecondOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("powerUpShotSecondOffsetPos_")]
    public Vector4 PowerUpShotSecondOffsetPos { get; set; } = Vector4.UnitW;
}