using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2400;

public class Em2400Param : EmBossBaseParam
{
    [JsonPropertyName("startWarpIndex_")]
    public int StartWarpIndex { get; set; } = 3;

    [JsonPropertyName("warpCameraTargetSec_")]
    public float WarpCameraTargetSec { get; set; } = 4f;

    [JsonPropertyName("warpCameraTargetDelaySec_")]
    public float WarpCameraTargetDelaySec { get; set; } = 0.1f;

    [JsonPropertyName("warpCameraTargetRate_")]
    public float WarpCameraTargetRate { get; set; } = 0.01f;

    [JsonPropertyName("warpPositions_")]
    public BindingList<Vector4> WarpPositions { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("guardDamageRate_")]
    public float GuardDamageRate { get; set; } = 0.5f;

    [JsonPropertyName("guardKnockBackRate_")]
    public float GuardKnockBackRate { get; set; } = 0.13f;

    [JsonPropertyName("guardBarrierVanishSec_")]
    public float GuardBarrierVanishSec { get; set; } = 1f;

    [JsonPropertyName("spherePositionSets_")]
    public BindingList<Vector4> SpherePositionSets { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("sphereExplodeHitCount_")]
    public int SphereExplodeHitCount { get; set; } = 1;

    [JsonPropertyName("sphereExplodeWaitSec_")]
    public float SphereExplodeWaitSec { get; set; } = 1f;

    [JsonPropertyName("doomsdayLoopSec_")]
    public float DoomsdayLoopSec { get; set; } = 12.5f;

    [JsonPropertyName("doomsdayExplodeSec_")]
    public float DoomsdayExplodeSec { get; set; } = 17f;

    [JsonPropertyName("doomsdayOffsetPos_")]
    public Vector4 DoomsdayOffsetPos { get; set; } = new Vector4(0f, 10f, 0f, 1f);

    [JsonPropertyName("magicCirclePositions_")]
    public BindingList<Vector4> MagicCirclePositions { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("magicCircleWaitEndSec_")]
    public float MagicCircleWaitEndSec { get; set; } = 2f;

    [JsonPropertyName("magicCircleDelaySec_")]
    public float MagicCircleDelaySec { get; set; } = 2f;

    [JsonPropertyName("beamRootNum_")]
    public int BeamRootNum { get; set; } = 8;

    [JsonPropertyName("beamLoopCount_")]
    public int BeamLoopCount { get; set; } = 2;

    [JsonPropertyName("beamNum_")]
    public int BeamNum { get; set; } = 3;

    [JsonPropertyName("beamWaitEndSec_")]
    public float BeamWaitEndSec { get; set; } = 7f;

    [JsonPropertyName("beamOffsetDegreeX_")]
    public float BeamOffsetDegreeX { get; set; } = 5f;

    [JsonPropertyName("eyeCtrlParam_")]
    public Em2400Param EyeCtrlParam { get; set; }

    public Em2400Param()
    {
        Hp = 340000;
        Atk = 1200;
        Break = 10;
        Def = 0f;
        Endurance = 10;
        Exp = 20;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 0;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 10f;
        DamageToHateRate = 0.02f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 70;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 1000f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 1f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
        CameraLength = 4.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1f;
        OdDefenseRateFirstTime = 1f;
        OdAttackRateSecondTime = 1f;
        OdDefenseRateSecondTime = 1f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }
}
