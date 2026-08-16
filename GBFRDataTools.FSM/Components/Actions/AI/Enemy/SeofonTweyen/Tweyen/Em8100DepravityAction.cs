using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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
public class Em8100DepravityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100DepravityAction);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "";

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; } = "depravity";

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 30;

    [JsonPropertyName("shotRandomSplitValue_")]
    public int ShotRandomSplitValue { get; set; } = 4;

    [JsonPropertyName("shotRapidInterval_")]
    public float ShotRapidInterval { get; set; } = 0.1f;

    [JsonPropertyName("shotHeightOffsetList_")]
    public BindingList<float> ShotHeightOffsetList { get; set; } = []; // std::vector<float>

    [JsonPropertyName("shotOffsetZ_")]
    public float ShotOffsetZ { get; set; } = 0.3f;

    [JsonPropertyName("atkWidth_")]
    public float AtkWidth { get; set; } = 5f;

    [JsonPropertyName("attackSignTimeSec_")]
    public float AttackSignTimeSec { get; set; } = 2f;

    [JsonPropertyName("attackSignTimeSecCenterMode_")]
    public float AttackSignTimeSecCenterMode { get; set; } = 3.5f;

    [JsonPropertyName("atkDepth_")]
    public float AtkDepth { get; set; } = 100f;

    [JsonPropertyName("atkSignWidthOffset_")]
    public float AtkSignWidthOffset { get; set; } = 0.5f;

    [JsonPropertyName("atkSignMoveAdjustRate_")]
    public float AtkSignMoveAdjustRate { get; set; } = 1.5f;

    [JsonPropertyName("debbuffNameList_")]
    public BindingList<string> DebbuffNameList { get; set; } = []; // std::vector<std::basic_string>

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 0.01f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.2f;

    [JsonPropertyName("centerTurnRate_")]
    public float CenterTurnRate { get; set; } = 0.8f;

    [JsonPropertyName("startDirOffset_")]
    public float StartDirOffset { get; set; } = 90f;

    [JsonPropertyName("startDirOffsetCenterMode_")]
    public float StartDirOffsetCenterMode { get; set; } = 45f;

    [JsonPropertyName("centerModeThresholdDist_")]
    public float CenterModeThresholdDist { get; set; } = 20f;

    [JsonPropertyName("isTargetHomingMode_")]
    public bool IsTargetHomingMode { get; set; } = true;

    [JsonPropertyName("turnToTargetRate_")]
    public float TurnToTargetRate { get; set; } = 0.03f;

    [JsonPropertyName("turnToTargetAngleMax_")]
    public float TurnToTargetAngleMax { get; set; } = 0.03f;

    [JsonPropertyName("turnToTargetTimeSec_")]
    public float TurnToTargetTimeSec { get; set; } = 2.5f;

    [JsonPropertyName("turnDecelerationTimeSec_")]
    public float TurnDecelerationTimeSec { get; set; } = 1.5f;

    [JsonPropertyName("atkSignMoveEaseParam_")]
    public EaseParam AtkSignMoveEaseParam { get; set; } = new();
}