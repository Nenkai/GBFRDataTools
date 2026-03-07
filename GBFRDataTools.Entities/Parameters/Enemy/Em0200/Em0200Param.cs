using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0200;

public class Em0200Param : EnemyParameterInfo
{
    [JsonPropertyName("dodgeInvisibleTime_")]
    public float DodgeInvisibleTime { get; set; } = 0.2f;

    [JsonPropertyName("dodgePercent_")]
    public float DodgePercent { get; set; } = 0.3f;

    [JsonPropertyName("backStepCoolTime_")]
    public float BackStepCoolTime { get; set; } = 1.5f;

    [JsonPropertyName("dodgeCoolTime_")]
    public float DodgeCoolTime { get; set; } = 4f;

    [JsonPropertyName("attackAfterDodgeCoolTime_")]
    public float AttackAfterDodgeCoolTime { get; set; } = 0.3f;

    [JsonPropertyName("dashAttackCoolTime_")]
    public float DashAttackCoolTime { get; set; } = 20f;

    [JsonPropertyName("dashSignGroundCheckHeight_")]
    public float DashSignGroundCheckHeight { get; set; } = 5f;

    [JsonPropertyName("tutorialCombatPower_")]
    public int TutorialCombatPower { get; set; } = 100;

    [JsonPropertyName("riderDoubleRushCoolTime_")]
    public float RiderDoubleRushCoolTime { get; set; } = 8f;

    [JsonPropertyName("noAttackHpPercent_")]
    public int NoAttackHpPercent { get; set; } = 25;

    [JsonPropertyName("riderUiOffsetY_")]
    public float RiderUiOffsetY { get; set; } = 0.8f;

    public Em0200Param()
    {
        Hp = 2500;
        Atk = 100;
        Break = 3;
        Def = 0.05f;
        Endurance = 1;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 35;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 15;
        HateRateBackAngle = 0;
        HateRateDamage = 25;
        HateRateManualPlayer = 30;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 25;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 30;
        ItemRewordMoneyVal = 40;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 7f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 1f;
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
        StageInvisibleStartDistance = 100f;
        StageInvisibleEndDistance = 125f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}
