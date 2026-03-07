using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0600_Slime;

public class Em0603Param : EmSlimeBaseParam
{
    [JsonPropertyName("requestEscapeAction_")]
    public float RequestEscapeAction { get; set; } = 90f;

    [JsonPropertyName("tailActionCoolTime_")]
    public float TailActionCoolTime { get; set; } = 15f;

    public Em0603Param()
    {
        Hp = 60000;
        Atk = 400;
        Break = 5;
        Def = 0f;
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
        CombatPower = 60;
        ItemRewordMoneyVal = 1000;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0.5f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 0;
        UiOffsetY = 1.2f;
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
        EscapeDamageStackMax = 250f;
        HitStopTimeScale = 0.25f;
        SpecialArtsDamageScale = 7.5f;
        LinkAttackDamageScale = 5f;
        DropMoneyHpRate = 0f;
        DropMoney = 100;
        CanGetMoneyMaxValue = 2460;
        LinkAttackDamageDropMoneyVal = 200;
        LinkFinishDamageDropMoneyVal = 500;
        DamageCutPercent = 0f;
        RunBoundMax = 3;
        RunMoveAngle = 1f;
        RunMoveTime = 1f;
        RunLastMoveTime = 0.2f;
        EscapeTimeSecMax = 10f;
        EscapeTimeSecMin = 2f;
        EscapeTimeSecDecreaseNum = 3;
    }
}
