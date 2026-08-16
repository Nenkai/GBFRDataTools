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
public class SummonSniperModeMotionAction : SummonSniperModeAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSniperModeMotionAction);

    [JsonPropertyName("isActiveDebugDraw_")]
    [Obsolete("Not exposed by the executable")]
    public bool IsActiveDebugDraw { get; set; } = false;

    [JsonPropertyName("aimMotionSlot_")]
    public int AimMotionSlot { get; set; } = 0;

    [JsonPropertyName("turnMotionSlot_")]
    public int TurnMotionSlot { get; set; } = 0;

    [JsonPropertyName("shotMotionSlot_")]
    public int ShotMotionSlot { get; set; } = 0;

    [JsonPropertyName("frontAnimId_")]
    public string FrontAnimId { get; set; }

    [JsonPropertyName("upAnimId_")]
    public string UpAnimId { get; set; }

    [JsonPropertyName("downAnimId_")]
    public string DownAnimId { get; set; }

    [JsonPropertyName("leftAnimId_")]
    public string LeftAnimId { get; set; }

    [JsonPropertyName("rightAnimId_")]
    public string RightAnimId { get; set; }

    [JsonPropertyName("waitAnimId_")]
    public string WaitAnimId { get; set; }

    [JsonPropertyName("turnLeftAnimId_")]
    public string TurnLeftAnimId { get; set; }

    [JsonPropertyName("turnRightAnimId_")]
    public string TurnRightAnimId { get; set; }

    [JsonPropertyName("motionBlendRotXMul_")]
    public float MotionBlendRotXMul { get; set; } = 0f;

    [JsonPropertyName("motionBlendRotXAdd_")]
    public float MotionBlendRotXAdd { get; set; } = 0f;

    [JsonPropertyName("vecOutputBlackBoardKey_")]
    public string VecOutputBlackBoardKey { get; set; }

    public SummonSniperModeMotionAction()
    {
        PartsNo = 0;
        ShotOffsetPos = Vector4.UnitW;
        AimCamRate = 0f;
        AimCamSpeedRate = 0f;
        AimCamCenterRange = 0f;
        IsUseAimCamCenterMinRange = false;
        AimCamCenterMinRange = 0f;
        HomingMinRange = 0f;
        IsUseCharaPosHomingRange = false;
        IsAimCamRotXUpDownMax = false;
        AimCamRotXMax = 0f;
        AimCamRotXUpMax = 0f;
        AimCamRotXDownMax = 0f;
        IsTurnCharacter = false;
        TurnRate = 0f;
        TurnMax = 0f;
        IsHoming = false;
        HomingDist = 100f;
        HomingRate = 0.25f;
        ShotHomingSetIntervalFrame = 6;
        CanCameraControlStickL = true;
        IsAimAdjustment = false;
        AdjustMinValue = 0f;
        VecRotRate = 0f;
        VecRotRadMinValue = 0f;
    }
}
