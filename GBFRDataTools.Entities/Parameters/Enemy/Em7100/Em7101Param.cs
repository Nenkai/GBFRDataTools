using System.ComponentModel;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7100;

public class Em7101Param : EnemyParameterInfo
{
    [JsonPropertyName("bodyShellParams_")]
    public BindingList<Em7100ShellParam> BodyShellParams { get; set; } = []; // std::vector<Em7100ShellParam>

    [JsonPropertyName("tailShellParams_")]
    public BindingList<Em7100ShellParam> TailShellParams { get; set; } = []; // std::vector<Em7100ShellParam>

    [JsonPropertyName("addDamageParam_")]
    public EmAddDamageParam AddDamageParam { get; set; }

    [JsonPropertyName("tailLockOnParam_")]
    public EmLockOnParam TailLockOnParam { get; set; }

    [JsonPropertyName("tailLinkParam_")]
    public EmLinkAttackParam TailLinkParam { get; set; }

    [JsonPropertyName("bodyFireCoreLineOffset_")]
    public Vector4 BodyFireCoreLineOffset { get; set; } = new Vector4(13f, 10f, 6f, 1f);

    [JsonPropertyName("tailFireCoreLineOffset_")]
    public Vector4 TailFireCoreLineOffset { get; set; } = new Vector4(13f, 10f, 0f, 1f);

    public Em7101Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
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
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 3840;
        UiOffsetY = -0.6f;
        BasicHitStopTimeRate = 1f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.5f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
    }
}