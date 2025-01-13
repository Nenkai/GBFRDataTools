using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0800_Seed;

public class Em0802Param : EmSeedParam
{
    [JsonPropertyName("rockWaveWidth_")]
    public float RockWaveWidth { get; set; } = 3f;

    [JsonPropertyName("rockWaveHeight_")]
    public float RockWaveHeight { get; set; } = 1f;

    [JsonPropertyName("rockWaveAtkRate_")]
    public float RockWaveAtkRate { get; set; } = 1f;

    [JsonPropertyName("rockWaveBreakRate_")]
    public float RockWaveBreakRate { get; set; } = 0.1f;

    [JsonPropertyName("rockWaveEffectCallLength_")]
    public float RockWaveEffectCallLength { get; set; } = 1f;

    [JsonPropertyName("rockMineCoolTime_")]
    public float RockMineCoolTime { get; set; } = 4f;

    [JsonPropertyName("minionStartRandomCoolTimeMin_")]
    public float MinionStartRandomCoolTimeMin { get; set; } = 0f;

    [JsonPropertyName("minionStartRandomCoolTimeMax_")]
    public float MinionStartRandomCoolTimeMax { get; set; } = 5f;

    public Em0802Param()
    {
        Hp = 4500;
        Atk = 100;
        Break = 3;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 50;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
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
        CombatPower = 30;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 2304;
        UiOffsetY = 2f;
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
        HitCheckLength = 3f;
        ShotCoolTime = 20f;
        BackStepCoolTime = 7f;
        LiftUpCollisionRadius = 0.2f;
        BlowVecRate = 0.1f;
        BlowRotRate = 1f;
        ThrowGravityRate = 0.15f;
        BlowBombAtkRate = 10f;
        BlowBombBreakRate = 30f;
        BlowBombHitStop = 10;
        BlowBombAttackSignSize = 6f;
    }
}