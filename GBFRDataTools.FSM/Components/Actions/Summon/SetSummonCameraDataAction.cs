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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SetSummonCameraDataAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetSummonCameraDataAction);

    [JsonPropertyName("offset_")]
    public Vector4 Offset { get; set; } = new Vector4(0f, 1.8f, 0f, 1f);

    [JsonPropertyName("length_")]
    public float Length { get; set; } = 4.8f;

    [JsonPropertyName("isAutoFront_")]
    public bool IsAutoFront { get; set; } = false;

    [JsonPropertyName("isPrevAutoFront_")]
    public bool IsPrevAutoFront { get; set; } = false;

    [JsonPropertyName("autoFrontRotYOffset_")]
    public float AutoFrontRotYOffset { get; set; } = 0f;

    [JsonPropertyName("autoFrontRate_")]
    public float AutoFrontRate { get; set; } = 0.1f;

    [JsonPropertyName("isRSControlLocked_")]
    public bool IsRSControlLocked { get; set; } = false;

    [JsonPropertyName("isLeftCameraView_")]
    public bool IsLeftCameraView { get; set; } = false;

    [JsonPropertyName("leftCameraOffsetRotY_")]
    public float LeftCameraOffsetRotY { get; set; } = -1f;

    [JsonPropertyName("setParameterTimerSec_")]
    public float SetParameterTimerSec { get; set; } = 0f;

    [JsonPropertyName("giantEnemyLength_")]
    public float GiantEnemyLength { get; set; } = 10f;

    [JsonPropertyName("giantEnemyOffsetY_")]
    public float GiantEnemyOffsetY { get; set; } = 3f;

    [JsonPropertyName("isApplyGiantEnemyParam_")]
    public bool IsApplyGiantEnemyParam { get; set; } = false;
}
