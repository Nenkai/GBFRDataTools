using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl1400Param : PlayerParameterInfo
{
    [JsonPropertyName("isUseNewGenziMesh_")]
    public bool IsUseNewGenziMesh { get; set; } = false;

    [JsonPropertyName("limitButterflyMaxNum_")]
    public int LimitButterflyMaxNum { get; set; } = 3;

    [JsonPropertyName("butterFly_Num_")]
    public int ButterFly_Num { get; set; } = 6;

    [JsonPropertyName("butterFly_Time_")]
    public float ButterFly_Time { get; set; } = 180f;

    [JsonPropertyName("butterFlt_AddAtkRate_")]
    public float ButterFlt_AddAtkRate { get; set; } = 0.05f;

    [JsonPropertyName("butterFlt_AddBreakRate_")]
    public float ButterFlt_AddBreakRate { get; set; } = 0.05f;

    [JsonPropertyName("kaguraRapidTime_")]
    public float KaguraRapidTime { get; set; } = 2f;

    [JsonPropertyName("genziCharge_AtkDist")]
    public float GenziCharge_AtkDist { get; set; } = 15f;

    [JsonPropertyName("genziCharge_ATkDir_")]
    public float GenziCharge_ATkDir { get; set; } = 135f;

    [JsonPropertyName("genziCharge_ChargeTime_")]
    public float GenziCharge_ChargeTime { get; set; } = 1.5f;

    [JsonPropertyName("genziCharge_Height_")]
    public float GenziCharge_Height { get; set; } = 5f;

    [JsonPropertyName("genziCharge_AtkNum_Lv1")]
    public int GenziCharge_AtkNum_Lv1 { get; set; } = 2;

    [JsonPropertyName("genziCharge_AtkNum_Lv2")]
    public int GenziCharge_AtkNum_Lv2 { get; set; } = 3;

    [JsonPropertyName("genziCharge_AtkNum_Lv3")]
    public int GenziCharge_AtkNum_Lv3 { get; set; } = 5;

    [JsonPropertyName("genziCharge_AtkNum_Combo3Lv3")]
    public int GenziCharge_AtkNum_Combo3Lv3 { get; set; } = 1;

    [JsonPropertyName("atkBuff_BaseRate_")]
    public float AtkBuff_BaseRate { get; set; } = 0.1f;

    [JsonPropertyName("atkBuff_AddRate_")]
    public float AtkBuff_AddRate { get; set; } = 0.1f;

    [JsonPropertyName("atkBuff_BaseTime_")]
    public float AtkBuff_BaseTime { get; set; } = 10f;

    [JsonPropertyName("atkBuff_AddTime_")]
    public float AtkBuff_AddTime { get; set; } = 5f;

    [JsonPropertyName("doubleAtk_AtkRate_")]
    public float DoubleAtk_AtkRate { get; set; } = 30f;

    [JsonPropertyName("doubleAtk_delayFrame_")]
    public int DoubleAtk_delayFrame { get; set; } = 5;

    [JsonPropertyName("defBuff_BaseRate_")]
    public float DefBuff_BaseRate { get; set; } = 0.1f;

    [JsonPropertyName("defBuff_AddRate_")]
    public float DefBuff_AddRate { get; set; } = 0.1f;

    [JsonPropertyName("defBuff_BaseTime_")]
    public float DefBuff_BaseTime { get; set; } = 10f;

    [JsonPropertyName("defBuff_AddTime_")]
    public float DefBuff_AddTime { get; set; } = 5f;

    [JsonPropertyName("defBuf_HealRate_")]
    public float DefBuf_HealRate { get; set; } = 0.75f;

    [JsonPropertyName("defBuf_HealLimit_")]
    public float DefBuf_HealLimit { get; set; } = 40000f;

    [JsonPropertyName("hateForce_DebufBaseRate_")]
    public float HateForce_DebufBaseRate { get; set; } = 0.25f;

    [JsonPropertyName("hateForce_DebufAddRate_")]
    public float HateForce_DebufAddRate { get; set; } = 0f;

    [JsonPropertyName("genziVfxColor_")]
    public Vector4[] GenziVfxColor { get; set; } = new Vector4[3]; // std::array<Hw::cVec4,3>

    public Pl1400Param()
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
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 0.7999999f;
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 2.5f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 7999;
        DamageLimitNormalAttack2 = 19999;
        DamageLimitSpecialAttack = 9999;
        DamageLimitAbility01 = 34999;
        DamageLimitAbility02 = 199999;
        DamageLimitAbility03 = 84999;
        DamageLimitAbility04 = 39999;
        DamageLimitAbility05 = 44999;
        DamageLimitAbility06 = 24999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 64999;
    }
}
