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
public class SummonSniperModeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSniperModeAction);

    [JsonPropertyName("partsNo_")]
    public int PartsNo { get; set; } = 0;

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("aimCamRate_")]
    public float AimCamRate { get; set; } = 0f;

    [JsonPropertyName("aimCamSpeedRate_")]
    public float AimCamSpeedRate { get; set; } = 0f;

    [JsonPropertyName("aimCamCenterRange_")]
    public float AimCamCenterRange { get; set; } = 0f;

    [JsonPropertyName("isUseAimCamCenterMinRange_")]
    public bool IsUseAimCamCenterMinRange { get; set; } = false;

    [JsonPropertyName("aimCamCenterMinRange_")]
    public float AimCamCenterMinRange { get; set; } = 0f;

    [JsonPropertyName("homingMinRange_")]
    public float HomingMinRange { get; set; } = 0f;

    [JsonPropertyName("isUseCharaPosHomingRange_")]
    public bool IsUseCharaPosHomingRange { get; set; } = false;

    [JsonPropertyName("isAimCamRotXUpDownMax_")]
    public bool IsAimCamRotXUpDownMax { get; set; } = false;

    [JsonPropertyName("aimCamRotXMax_")]
    public float AimCamRotXMax { get; set; } = 0f;

    [JsonPropertyName("aimCamRotXUpMax_")]
    public float AimCamRotXUpMax { get; set; } = 0f;

    [JsonPropertyName("aimCamRotXDownMax_")]
    public float AimCamRotXDownMax { get; set; } = 0f;

    [JsonPropertyName("isTurnCharacter_")]
    public bool IsTurnCharacter { get; set; } = false;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0f;

    [JsonPropertyName("turnMax_")]
    public float TurnMax { get; set; } = 0f;

    [JsonPropertyName("sniperPosBlackBoardKey_")]
    public string SniperPosBlackBoardKey { get; set; }

    [JsonPropertyName("rotOutputBlackBoardKey_")]
    public string RotOutputBlackBoardKey { get; set; }

    [JsonPropertyName("isCanControlBlackBoardKey_")]
    public string IsCanControlBlackBoardKey { get; set; }

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; } = false;

    [JsonPropertyName("homingDist_")]
    public float HomingDist { get; set; } = 100f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.25f;

    [JsonPropertyName("shotHomingSetIntervalFrame_")]
    public int ShotHomingSetIntervalFrame { get; set; } = 6;

    [JsonPropertyName("canCameraControlStickL_")]
    public bool CanCameraControlStickL { get; set; } = true;

    [JsonPropertyName("isAimAdjustment_")]
    public bool IsAimAdjustment { get; set; } = false;

    [JsonPropertyName("adjustMinValue_")]
    public float AdjustMinValue { get; set; } = 0f;

    [JsonPropertyName("vecRotRate_")]
    public float VecRotRate { get; set; } = 0f;

    [JsonPropertyName("vecRotRadMinValue_")]
    public float VecRotRadMinValue { get; set; } = 0f;

    [JsonPropertyName("isActiveHudDebug_")]
    [Obsolete("Not exposed by executable")]
    public bool IsActiveHudDebug { get; set; } = false;

    [JsonPropertyName("isActiveShotDebug_")]
    [Obsolete("Not exposed by executable")]
    public bool IsActiveShotDebug { get; set; } = false;
}
