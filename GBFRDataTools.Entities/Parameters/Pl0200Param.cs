using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0200Param : PlayerParameterInfo
{
    [JsonPropertyName("isEnableSecondSpArts_")]
    public bool IsEnableSecondSpArts { get; set; }

    [JsonPropertyName("motOffsetWeaponList_")]
    public BindingList<int> MotOffsetWeaponList { get; set; } = []; // std::array<int, 4>

    [JsonPropertyName("rapidAttackTime_")]
    public float RapidAttackTime { get; set; }

    [JsonPropertyName("rapidInputCancelFrame_")]
    public float RapidInputCancelFrame { get; set; }

    [JsonPropertyName("aresRapidAttackTime_")]
    public float AresRapidAttackTime { get; set; }

    [JsonPropertyName("ability_EnchantRuns_Speed_")]
    public float Ability_EnchantRuns_Speed { get; set; }

    [JsonPropertyName("ability_EnchantRuns_HitTime_")]
    public float Ability_EnchantRuns_HitTime { get; set; }

    [JsonPropertyName("ability_DefUpTime_")]
    public float Ability_DefUpTime { get; set; }

    [JsonPropertyName("ability_DefUpRate_")]
    public float Ability_DefUpRate { get; set; }

    [JsonPropertyName("ability_HealRate_")]
    public float Ability_HealRate { get; set; }

    [JsonPropertyName("ability_HealRateWithAres_")]
    public float Ability_HealRateWithAres { get; set; }

    [JsonPropertyName("ability_Invinsible_")]
    public float Ability_Invinsible { get; set; }

    [JsonPropertyName("aresGauge_PointMax")]
    public float AresGauge_PointMax { get; set; }

    [JsonPropertyName("aresGauge_AddPoint_Lv1")]
    public float AresGauge_AddPoint_Lv1 { get; set; }

    [JsonPropertyName("aresGauge_AddPoint_Lv2")]
    public float AresGauge_AddPoint_Lv2 { get; set; }

    [JsonPropertyName("aresGauge_AddPoint_Lv3")]
    public float AresGauge_AddPoint_Lv3 { get; set; }

    [JsonPropertyName("aresJumpIntervalTime_")]
    public float AresJumpIntervalTime { get; set; }

    [JsonPropertyName("aresJumpSpeedY_")]
    public float AresJumpSpeedY { get; set; }

    [JsonPropertyName("aresJumpGravityRate_")]
    public float AresJumpGravityRate { get; set; }

    [JsonPropertyName("aresSummonTime_")]
    public float AresSummonTime { get; set; }

    [JsonPropertyName("aresLevelDownTime_")]
    public float AresLevelDownTime { get; set; }

    [JsonPropertyName("aresLvUp_ReStartTime_")]
    public float AresLvUp_ReStartTime { get; set; }

    [JsonPropertyName("aresNotEraseTime_")]
    public float AresNotEraseTime { get; set; }

    [JsonPropertyName("aresAttackWarpDist_")]
    public float AresAttackWarpDist { get; set; }

    [JsonPropertyName("aresRushAttackWarpDist_")]
    public float AresRushAttackWarpDist { get; set; }

    [JsonPropertyName("ability_SummonAresTime_")]
    public float Ability_SummonAresTime { get; set; }

    [JsonPropertyName("aresLevel2_AttackRate")]
    public float AresLevel2_AttackRate { get; set; }

    [JsonPropertyName("aresLevel3_AttackRate")]
    public float AresLevel3_AttackRate { get; set; }

    [JsonPropertyName("aresLevel2_BreakRate")]
    public float AresLevel2_BreakRate { get; set; }

    [JsonPropertyName("aresLevel3_BreakRate")]
    public float AresLevel3_BreakRate { get; set; }

    [JsonPropertyName("aresLevel2_DeffenceRate")]
    public float AresLevel2_DeffenceRate { get; set; }

    [JsonPropertyName("aresLevel3_DeffenceRate")]
    public float AresLevel3_DeffenceRate { get; set; }

    [JsonPropertyName("limitBonusDefRateLv1_")]
    public float LimitBonusDefRateLv1 { get; set; }

    [JsonPropertyName("limitBonusDefRateLv2_")]
    public float LimitBonusDefRateLv2 { get; set; }

    [JsonPropertyName("limitBonusDefRateLv3_")]
    public float LimitBonusDefRateLv3 { get; set; }

    [JsonPropertyName("addIndirectDamagePointUnique_lv1_")]
    public float AddIndirectDamagePointUnique_lv1 { get; set; }

    [JsonPropertyName("addIndirectDamagePointUnique_lv2_")]
    public float AddIndirectDamagePointUnique_lv2 { get; set; }
}
