using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl2300Param : PlayerParameterInfo
{
    [JsonPropertyName("isMultiLockLongInputBranch_")]
    public bool IsMultiLockLongInputBranch { get; set; } = true;

    [JsonPropertyName("isViewDebugGauge_")]
    public bool IsViewDebugGauge { get; set; } = false;

    [JsonPropertyName("normalShotMoveSpeed_")]
    public float NormalShotMoveSpeed { get; set; } = 0.05f;

    [JsonPropertyName("normalShotBlendInterRate_")]
    public float NormalShotBlendInterRate { get; set; } = 0.1f;

    [JsonPropertyName("airPowerShotRotX_")]
    public float AirPowerShotRotX { get; set; } = 20f;

    [JsonPropertyName("stackPointArray_")]
    [Editable(false)]
    public BindingList<float> StackPointArray { get; set; } = [.. Enumerable.Repeat(0, 27).ToList()]; // std::array<float,27>

    [JsonPropertyName("aimCameraRate_")]
    public float AimCameraRate { get; set; } = 0.3f;

    [JsonPropertyName("aimCameraSpeed_")]
    public float AimCameraSpeed { get; set; } = 1f;

    [JsonPropertyName("multiLockAddIntervalSec_")]
    public float MultiLockAddIntervalSec { get; set; } = 0.08f;

    [JsonPropertyName("multiLockShotIntervalFrame_")]
    public float MultiLockShotIntervalFrame { get; set; } = 5f;

    [JsonPropertyName("multiLockMeleeModeDist_")]
    public float MultiLockMeleeModeDist { get; set; } = 20f;

    [JsonPropertyName("multiLockLv2Line_")]
    public int MultiLockLv2Line { get; set; } = 4;

    [JsonPropertyName("multiLockLv3Line_")]
    public int MultiLockLv3Line { get; set; } = 7;

    [JsonPropertyName("depravityDebuffShotMaxNum_")]
    public int DepravityDebuffShotMaxNum { get; set; } = 45;

    [JsonPropertyName("depravityShotIntervalFrame_")]
    public float DepravityShotIntervalFrame { get; set; } = 3f;

    [JsonPropertyName("clincherAtkBonusParamArray_")]
    [Editable(false)]
    public BindingList<float> ClincherAtkBonusParamArray { get; set; } = [.. Enumerable.Repeat(0, 8).ToList()]; // std::array<float,8>

    [JsonPropertyName("spinUpperShotStartOffset_")]
    public Vector4 SpinUpperShotStartOffset { get; set; } = new Vector4(0f, 1f, 2f, 1f);

    [JsonPropertyName("spinUpperShotStartRotY_")]
    public float SpinUpperShotStartRotY { get; set; } = 70f;

    [JsonPropertyName("spinUpperShotAddRotValue_")]
    public float SpinUpperShotAddRotValue { get; set; } = 10f;

    [JsonPropertyName("spinUpperShotIntervalFrame_")]
    public float SpinUpperShotIntervalFrame { get; set; } = 2f;

    [JsonPropertyName("spinUpperShotOnceShotNum_")]
    public int SpinUpperShotOnceShotNum { get; set; } = 3;

    [JsonPropertyName("arrowRainCallSeDelaySec_")]
    public float ArrowRainCallSeDelaySec { get; set; } = 0.5f;

    [JsonPropertyName("arrowRainCallSeSec_")]
    public float ArrowRainCallSeSec { get; set; } = 1f;

    [JsonPropertyName("avoidAbilityUseRangeByAI_")]
    public float AvoidAbilityUseRangeByAI { get; set; } = 10f;

    [JsonPropertyName("walkShotTargetSelectParam_")]
    public PlayerLockOnParameter WalkShotTargetSelectParam { get; set; }

    public Pl2300Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 2f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 3499;
        DamageLimitNormalAttack2 = 9999;
        DamageLimitSpecialAttack = 14999;
        DamageLimitAbility01 = 9999;
        DamageLimitAbility02 = 3999;
        DamageLimitAbility03 = 199999;
        DamageLimitAbility04 = 19999;
        DamageLimitAbility05 = 7999;
        DamageLimitAbility06 = 19999;
        DamageLimitAbility07 = 9999;
        DamageLimitAbility08 = 74999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 24999;
    }
}
