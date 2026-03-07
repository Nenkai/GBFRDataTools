using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0000;

public class Em0004Param : EnemyParameterInfo
{
    [JsonPropertyName("targetLineTime_")]
    public float TargetLineTime { get; set; } = 0.2f;

    [JsonPropertyName("wobbleTime_")]
    public float WobbleTime { get; set; } = 1f;

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; } = 0f;

    [JsonPropertyName("rushAttackCoolTime_")]
    public float RushAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("jumpAttackCoolTime_")]
    public float JumpAttackCoolTime { get; set; } = 15f;

    [JsonPropertyName("shieldLaunchCoolTime_")]
    public float ShieldLaunchCoolTime { get; set; } = 15f;

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("stabChoppingShootOffset1_")]
    public Vector3 StabChoppingShootOffset1 { get; set; } = new Vector3(0f, 0f, 0.1f);

    [JsonPropertyName("stabChoppingShootOffset23_")]
    public Vector3 StabChoppingShootOffset23 { get; set; } = new Vector3(1.5f, 0f, 0f);

    [JsonPropertyName("stabChoppingShootRot_")]
    public Vector3 StabChoppingShootRot { get; set; } = new Vector3(0f, 12f, -12f);

    public Em0004Param()
    {
        Hp = 10000;
        Atk = 400;
        Break = 5;
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
        CombatPower = 55;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 1;
        LinkAttackCameraDistRate = 0.25f;
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
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = true;
    }
}
