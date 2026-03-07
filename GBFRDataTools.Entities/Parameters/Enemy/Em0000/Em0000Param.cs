using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0000;

public class Em0000Param : EnemyParameterInfo
{
    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 3f;

    [JsonPropertyName("slashAttackCoolTime_")]
    public float SlashAttackCoolTime { get; set; } = 8f;

    [JsonPropertyName("jumpAttackCoolTime_")]
    public float JumpAttackCoolTime { get; set; } = 10f;

    [JsonPropertyName("backMoveCoolTime_")]
    public float BackMoveCoolTime { get; set; } = 10f;

    [JsonPropertyName("menacingCoolTime_")]
    public float MenacingCoolTime { get; set; } = 15f;

    [JsonPropertyName("defaultAttackHomingRate_")]
    public float DefaultAttackHomingRate { get; set; } = 0.2f;

    [JsonPropertyName("defaultAttackHomingMaxAngle_")]
    public float DefaultAttackHomingMaxAngle { get; set; } = 0.5f;

    [JsonPropertyName("defaultMoveToFormOffset_")]
    public float DefaultMoveToFormOffset { get; set; } = 1f;

    [JsonPropertyName("defaultMoveToMaxDist_")]
    public float DefaultMoveToMaxDist { get; set; } = 6f;

    [JsonPropertyName("clearRiderCheckHpRate_")]
    public float ClearRiderCheckHpRate { get; set; } = 0.2f;

    [JsonPropertyName("clearRiderCounterCheckDamageRate_")]
    public float ClearRiderCounterCheckDamageRate { get; set; } = 0.3f;

    public Em0000Param()
    {
        Hp = 2500;
        Atk = 100;
        Break = 3;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 35;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 15;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
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
        CombatPower = 35;
        ItemRewordMoneyVal = 20;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
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
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}
