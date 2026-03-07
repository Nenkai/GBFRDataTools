using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7500;

public class Em75b0Param : EnemyParameterInfo
{
    [JsonPropertyName("isUpdateHandPos_")]
    public bool IsUpdateHandPos { get; set; } = false;

    [JsonPropertyName("waitMoveDist_")]
    public float WaitMoveDist { get; set; } = 0.5f;

    [JsonPropertyName("handPosArray_")]
    [Editable(false)]
    public BindingList<BindingList<Vector4>> HandPosArray { get; set; } = [.. Enumerable.Repeat(new BindingList<Vector4>([.. Enumerable.Repeat(new Vector4(), 6)]), 3)]; // std::array<std::array<Hw::cVec4, 6>, 3>

    [JsonPropertyName("handPunchPosArray_")]
    [Editable(false)]
    public BindingList<BindingList<Vector4>> HandPunchPosArray { get; set; } = [.. Enumerable.Repeat(new BindingList<Vector4>([.. Enumerable.Repeat(new Vector4(), 6)]), 3)]; // std::array<std::array<Hw::cVec4, 6>, 3>

    [JsonPropertyName("handCounterPosArray_")]
    [Editable(false)]
    public BindingList<BindingList<Vector4>> HandCounterPosArray { get; set; } = [.. Enumerable.Repeat(new BindingList<Vector4>([.. Enumerable.Repeat(new Vector4(), 6)]), 3)]; // std::array<std::array<Hw::cVec4, 6>, 3>

    [JsonPropertyName("handBarrierPosArray_")]
    [Editable(false)]
    public BindingList<BindingList<Vector4>> HandBarrierPosArray { get; set; } = [.. Enumerable.Repeat(new BindingList<Vector4>([.. Enumerable.Repeat(new Vector4(), 6)]), 3)]; // std::array<std::array<Hw::cVec4, 6>, 3>

    public Em75b0Param()
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
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
    }
}