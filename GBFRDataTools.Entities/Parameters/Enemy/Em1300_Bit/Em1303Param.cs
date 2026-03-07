using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1300_Bit;
public class Em1303Param : BitBaseParam
{
    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f;

    [JsonPropertyName("selfBombDefDebuffSec_")]
    public float SelfBombDefDebuffSec { get; set; } = 60f;

    [JsonPropertyName("selfBombDefDebuffRate_")]
    public float SelfBombDefDebuffRate { get; set; } = 20f;

    [JsonPropertyName("liftupBombExplosionDamageRate_")]
    public float LiftupBombExplosionDamageRate { get; set; } = 15f;

    [JsonPropertyName("liftupBombExplosionBreakRate_")]
    public float LiftupBombExplosionBreakRate { get; set; } = 20f;

    [JsonPropertyName("liftupBombExplosionRadius_")]
    public float LiftupBombExplosionRadius { get; set; } = 5f;

    [JsonPropertyName("liftupBombAttackSignSize_")]
    public float LiftupBombAttackSignSize { get; set; } = 6f;

    [JsonPropertyName("blowVecRate_")]
    public float BlowVecRate { get; set; } = 0.125f;

    [JsonPropertyName("blowRotRate_")]
    public float BlowRotRate { get; set; } = 0.05f;

    public Em1303Param()
    {
        Hp = 700;
        Atk = 16;
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
        HateRateDamage = 0;
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
        UiPartsNo = 256;
        UiOffsetY = 0.5f;
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