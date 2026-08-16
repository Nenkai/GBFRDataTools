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
public class SummonTargetMarkerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonTargetMarkerAction);

    [JsonPropertyName("useAttackPredictionEffect_")]
    public bool UseAttackPredictionEffect { get; set; } = false;

    [JsonPropertyName("attackSignEndTime_")]
    public float AttackSignEndTime { get; set; } = 1f;

    [JsonPropertyName("markerPlayerOffsetPos_")]
    public Vector4 MarkerPlayerOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("markerMinDist_")]
    public float MarkerMinDist { get; set; } = 0f;

    [JsonPropertyName("markerMaxDist_")]
    public float MarkerMaxDist { get; set; } = 0f;

    [JsonPropertyName("markerTargetVfxScale_")]
    public float MarkerTargetVfxScale { get; set; } = 1f;

    [JsonPropertyName("initPosOffsetDist_")]
    public float InitPosOffsetDist { get; set; } = 0f;

    [JsonPropertyName("isMarkerInitDirCamera")]
    public bool IsMarkerInitDirCamera { get; set; } = false;

    [JsonPropertyName("markerMaxAngle_")]
    public float MarkerMaxAngle { get; set; } = 90f;

    [JsonPropertyName("tagMarkTracerType_")]
    public int TagMarkTracerType { get; set; } = 0;

    [JsonPropertyName("tracerHeightExtendRate_")]
    public float TracerHeightExtendRate { get; set; } = 1f;

    [JsonPropertyName("isTracerTouchGround")]
    public bool IsTracerTouchGround { get; set; } = false;

    [JsonPropertyName("isAngle_")]
    public bool IsAngle { get; set; } = false;

    [JsonPropertyName("isCallVfx_")]
    public bool IsCallVfx { get; set; } = true;

    [JsonPropertyName("isChangeCameraLookAt")]
    public bool IsChangeCameraLookAt { get; set; } = true;

    [JsonPropertyName("isUseParts_")]
    public bool IsUseParts { get; set; } = false;

    [JsonPropertyName("partsNoImgui_")]
    public int PartsNoImgui { get; set; } = -1;

    [JsonPropertyName("isLongPress_")]
    public bool IsLongPress { get; set; } = false;

    [JsonPropertyName("isPadSetting_")]
    public bool IsPadSetting { get; set; } = false;

    [JsonPropertyName("padInitialVelocity_")]
    public float PadInitialVelocity { get; set; } = 0.4f;

    [JsonPropertyName("padAcceleration_")]
    public float PadAcceleration { get; set; } = 0f;

    [JsonPropertyName("button_")]
    public int Button { get; set; } = 0;

    [JsonPropertyName("blackBoardValueName_")]
    public string BlackBoardValueName { get; set; }

    [JsonPropertyName("isUseCameraOffset_")]
    public bool IsUseCameraOffset { get; set; } = false;

    [JsonPropertyName("cameraOffsetPos_")]
    public Vector4 CameraOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isFixCamera_")]
    public bool IsFixCamera { get; set; } = false;

    [JsonPropertyName("cameraOffsetRot_")]
    public Vector2 CameraOffsetRot { get; set; } = Vector2.Zero;

    [JsonPropertyName("isSyncTargetPos_")]
    public bool IsSyncTargetPos { get; set; } = false;

    [JsonPropertyName("targetPosSyncIntervalSec_")]
    public float TargetPosSyncIntervalSec { get; set; } = 0.1f;
}