using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0200Param : PlayerParameterInfo
{
    [JsonPropertyName("isEnableSecondSpArts_")]
    public bool IsEnableSecondSpArts { get; set; } = true;

    [JsonPropertyName("motOffsetWeaponList_")]
    public int[] MotOffsetWeaponList { get; set; } = new int[4]; // std::array<int, 4>

    [JsonPropertyName("rapidAttackTime_")]
    public float RapidAttackTime { get; set; } = 0.9f;

    [JsonPropertyName("rapidInputCancelFrame_")]
    public float RapidInputCancelFrame { get; set; } = 15f;

    [JsonPropertyName("aresRapidAttackTime_")]
    public float AresRapidAttackTime { get; set; } = 4.5f;

    [JsonPropertyName("ability_EnchantRuns_Speed_")]
    public float Ability_EnchantRuns_Speed { get; set; } = 0.8f;

    [JsonPropertyName("ability_EnchantRuns_HitTime_")]
    public float Ability_EnchantRuns_HitTime { get; set; } = 0.3f;

    [JsonPropertyName("ability_DefUpTime_")]
    public float Ability_DefUpTime { get; set; } = 30f;

    [JsonPropertyName("ability_DefUpRate_")]
    public float Ability_DefUpRate { get; set; } = 0.15f;

    [JsonPropertyName("ability_HealRate_")]
    public float Ability_HealRate { get; set; } = 50f;

    [JsonPropertyName("ability_HealRateWithAres_")]
    public float Ability_HealRateWithAres { get; set; } = 80f;

    [JsonPropertyName("ability_Invinsible_")]
    public float Ability_Invinsible { get; set; } = 10f;

    [JsonPropertyName("aresGauge_PointMax")]
    public float AresGauge_PointMax { get; set; } = 5f;

    [JsonPropertyName("aresGauge_AddPoint_Lv1")]
    public float AresGauge_AddPoint_Lv1 { get; set; } = 1.26f;

    [JsonPropertyName("aresGauge_AddPoint_Lv2")]
    public float AresGauge_AddPoint_Lv2 { get; set; } = 2.5f;

    [JsonPropertyName("aresGauge_AddPoint_Lv3")]
    public float AresGauge_AddPoint_Lv3 { get; set; } = 3.75f;

    [JsonPropertyName("aresJumpIntervalTime_")]
    public float AresJumpIntervalTime { get; set; } = 0.12f;

    [JsonPropertyName("aresJumpSpeedY_")]
    public float AresJumpSpeedY { get; set; } = 0.1f;

    [JsonPropertyName("aresJumpGravityRate_")]
    public float AresJumpGravityRate { get; set; } = 1.05f;

    [JsonPropertyName("aresSummonTime_")]
    public float AresSummonTime { get; set; } = 30f;

    [JsonPropertyName("aresLevelDownTime_")]
    public float AresLevelDownTime { get; set; } = 30f;

    [JsonPropertyName("aresLvUp_ReStartTime_")]
    public float AresLvUp_ReStartTime { get; set; } = 1f;

    [JsonPropertyName("aresNotEraseTime_")]
    public float AresNotEraseTime { get; set; } = 1f;

    [JsonPropertyName("aresAttackWarpDist_")]
    public float AresAttackWarpDist { get; set; } = 7f;

    [JsonPropertyName("aresRushAttackWarpDist_")]
    public float AresRushAttackWarpDist { get; set; } = 10f;

    [JsonPropertyName("ability_SummonAresTime_")]
    public float Ability_SummonAresTime { get; set; } = 15f;

    [JsonPropertyName("aresLevel2_AttackRate")]
    public float AresLevel2_AttackRate { get; set; } = 0.15f;

    [JsonPropertyName("aresLevel3_AttackRate")]
    public float AresLevel3_AttackRate { get; set; } = 0.2f;

    [JsonPropertyName("aresLevel2_BreakRate")]
    public float AresLevel2_BreakRate { get; set; } = 0.1f;

    [JsonPropertyName("aresLevel3_BreakRate")]
    public float AresLevel3_BreakRate { get; set; } = 0.2f;

    [JsonPropertyName("aresLevel2_DeffenceRate")]
    public float AresLevel2_DeffenceRate { get; set; } = 0.06f;

    [JsonPropertyName("aresLevel3_DeffenceRate")]
    public float AresLevel3_DeffenceRate { get; set; } = 0.1f;

    [JsonPropertyName("limitBonusDefRateLv1_")]
    public float LimitBonusDefRateLv1 { get; set; } = 0.2f;

    [JsonPropertyName("limitBonusDefRateLv2_")]
    public float LimitBonusDefRateLv2 { get; set; } = 0.3f;

    [JsonPropertyName("limitBonusDefRateLv3_")]
    public float LimitBonusDefRateLv3 { get; set; } = 0.5f;

    [JsonPropertyName("addIndirectDamagePointUnique_lv1_")]
    public float AddIndirectDamagePointUnique_lv1 { get; set; } = 200f;

    [JsonPropertyName("addIndirectDamagePointUnique_lv2_")]
    public float AddIndirectDamagePointUnique_lv2 { get; set; } = 200f;

    public Pl0200Param()
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
        LimitDamageRate = 0.6f;
        LimitSpecialArtsDamageRate = 0.9f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 10f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 24999;
        DamageLimitSpecialAttack = 14999;
        DamageLimitAbility01 = 59999;
        DamageLimitAbility02 = 14999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 19999;
        DamageLimitAbility06 = 1;
        DamageLimitAbility07 = 9999;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 89999;
    }
}
