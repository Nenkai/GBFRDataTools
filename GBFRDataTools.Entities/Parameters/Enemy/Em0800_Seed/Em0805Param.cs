using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0800_Seed;

public class Em0805Param : EmSeedParam
{
    [JsonPropertyName("blowBombSlowTime_")]
    public float BlowBombSlowTime { get; set; } = 5f;

    [JsonPropertyName("blowBombSlowRate_")]
    public float BlowBombSlowRate { get; set; } = 1.5f;

    [JsonPropertyName("summonAdjustHpMaxRate_")]
    public float SummonAdjustHpMaxRate { get; set; } = 0.4f;

    [JsonPropertyName("summonShotCoolTime_")]
    public float SummonShotCoolTime { get; set; } = 10f;

    [JsonPropertyName("homePosFarDist_")]
    public Vector2 HomePosFarDist { get; set; } = new Vector2(15f, 5f);

    [JsonPropertyName("summonBehaviorCoolTime_")]
    public float SummonBehaviorCoolTime { get; set; } = 12f;

    [JsonPropertyName("callOfDarknessWaitSec_")]
    public float CallOfDarknessWaitSec { get; set; } = 5f;

    [JsonPropertyName("codShowSecondOmenRate_")]
    public float CodShowSecondOmenRate { get; set; } = 0.4f;

    [JsonPropertyName("codShowThirdOmenRate_")]
    public float CodShowThirdOmenRate { get; set; } = 0.7f;

    [JsonPropertyName("codOmenScale_")]
    public float CodOmenScale { get; set; } = 1f;

    [JsonPropertyName("codSecondAuraSpdRate_")]
    public float CodSecondAuraSpdRate { get; set; } = 2f;

    [JsonPropertyName("codThirdAuraSpdRate_")]
    public float CodThirdAuraSpdRate { get; set; } = 3f;

    [JsonPropertyName("codAuraRateInterpSec_")]
    public float CodAuraRateInterpSec { get; set; } = 0.2f;

    [JsonPropertyName("isUseBombAuraCodSpdRate_")]
    public bool IsUseBombAuraCodSpdRate { get; set; } = true;

    [JsonPropertyName("callOfDarknessDelaySec_")]
    public float CallOfDarknessDelaySec { get; set; } = 0.5f;

    [JsonPropertyName("blowBombSummonAtkRate_")]
    public float BlowBombSummonAtkRate { get; set; } = 6f;

    [JsonPropertyName("blowBombSummonBreakRate_")]
    public float BlowBombSummonBreakRate { get; set; } = 10f;

    [JsonPropertyName("blowBombSummonHitStop_")]
    public int BlowBombSummonHitStop { get; set; } = 10;

    [JsonPropertyName("bombModeDamageCutRate_")]
    public float BombModeDamageCutRate { get; set; } = 0.3f;

    [JsonPropertyName("bombModeAdjustHpMaxRate_")]
    public float BombModeAdjustHpMaxRate { get; set; } = 1.5f;

    [JsonPropertyName("bombModeScale_")]
    public float BombModeScale { get; set; } = 3.5f;

    [JsonPropertyName("bombModeCodWaitSec_")]
    public float BombModeCodWaitSec { get; set; } = 5f;

    [JsonPropertyName("bombModeCodShotCutSec_")]
    public float BombModeCodShotCutSec { get; set; } = 3f;

    [JsonPropertyName("bombModeExecCodSec_")]
    public float BombModeExecCodSec { get; set; } = 60f;

    [JsonPropertyName("bombModeWaveAtkSignDist_")]
    public float BombModeWaveAtkSignDist { get; set; } = 28f;

    public Em0805Param()
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
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
        HitCheckLength = 3f;
        ShotCoolTime = 7f;
        BackStepCoolTime = 7f;
        LiftUpCollisionRadius = 0.2f;
        BlowVecRate = 0.1f;
        BlowRotRate = 1f;
        ThrowGravityRate = 0.15f;
        BlowBombAtkRate = 4f;
        BlowBombBreakRate = 3f;
        BlowBombHitStop = 10;
        BlowBombAttackSignSize = 6f;
    }
}
