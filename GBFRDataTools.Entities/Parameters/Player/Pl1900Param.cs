using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl1900Param : PlayerParameterInfo
{
    [JsonPropertyName("rushStartMotRate_")]
    public float RushStartMotRate { get; set; } = 0.2f;

    [JsonPropertyName("ability_healRate")]
    public float Ability_healRate { get; set; } = 0.15f;

    [JsonPropertyName("ability_HealBonusRate_")]
    public float Ability_HealBonusRate { get; set; } = 1f;

    [JsonPropertyName("superModeTime_")]
    public float SuperModeTime { get; set; } = 60f;

    [JsonPropertyName("attackRate_Lv1")]
    public float AttackRate_Lv1 { get; set; } = 0.09999999f;

    [JsonPropertyName("attackRate_Lv2")]
    public float AttackRate_Lv2 { get; set; } = 0.2f;

    [JsonPropertyName("attackRate_Lv3")]
    public float AttackRate_Lv3 { get; set; } = 0.3f;

    [JsonPropertyName("attackRate_SuperMode")]
    public float AttackRate_SuperMode { get; set; } = 3f;

    [JsonPropertyName("chargeRush_rushTime_lv1_")]
    public float ChargeRush_rushTime_lv1 { get; set; } = 7f;

    [JsonPropertyName("chargeRush_rushTime_lv2_")]
    public float ChargeRush_rushTime_lv2 { get; set; } = 14f;

    [JsonPropertyName("chargeRush_rushTime_lv3_")]
    public float ChargeRush_rushTime_lv3 { get; set; } = 21f;

    [JsonPropertyName("chargeRush_rushTime_Limmit_")]
    public float ChargeRush_rushTime_Limmit { get; set; } = 5f;

    [JsonPropertyName("ability_coverDist_")]
    public float Ability_coverDist { get; set; } = 50f;

    [JsonPropertyName("ability_ChargeDmg_Percent_")]
    public float Ability_ChargeDmg_Percent { get; set; } = 3f;

    [JsonPropertyName("ability_ChargeDmg_Interval_")]
    public float Ability_ChargeDmg_Interval { get; set; } = 1f;

    [JsonPropertyName("superRushTime_")]
    public float SuperRushTime { get; set; } = 3f;

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_")]
    public float LinkTimeAbilityCoolTimeBonus { get; set; } = 0.2f;

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_Super_")]
    public float LinkTimeAbilityCoolTimeBonus_Super { get; set; } = 0.3f;

    [JsonPropertyName("addBahamutLvList_")]
    public BindingList<BahamutLvPointParam> AddBahamutLvList { get; set; } = []; // std::vector<Pl1900Param::BahamutLvPointParam>

    [JsonPropertyName("finishFireLineCheckStart_")]
    public float FinishFireLineCheckStart { get; set; } = 5f;

    [JsonPropertyName("finishFireLineCheckEnd_")]
    public float FinishFireLineCheckEnd { get; set; } = -5f;

    [JsonPropertyName("finishFireCenterPos_")]
    public Vector4 FinishFireCenterPos { get; set; } = new Vector4(0f, 0f, 4.5f, 1f);

    [JsonPropertyName("finishFireList_")]
    public BindingList<SuperFinishFireParam> FinishFireList { get; set; } = []; // std::vector<Pl1900Param::SuperFinishFireParam>

    public Pl1900Param()
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
        LimitDamageRate = 0.9f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 3.5f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 14999;
        DamageLimitNormalAttack2 = 19999;
        DamageLimitSpecialAttack = 49999;
        DamageLimitAbility01 = 29999;
        DamageLimitAbility02 = 59999;
        DamageLimitAbility03 = 99999;
        DamageLimitAbility04 = 19999;
        DamageLimitAbility05 = 99999;
        DamageLimitAbility06 = 199999;
        DamageLimitAbility07 = 34999;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 29999;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BahamutLvPointParam // Pl1900Param::BahamutLvPointParam
    {
        [JsonPropertyName("actionName_")]
        public string ActionName { get; set; }

        [JsonPropertyName("actionId_")]
        public int ActionId { get; set; }

        [JsonPropertyName("point_")]
        public float Point { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SuperFinishFireParam // Pl1900Param::SuperFinishFireParam
    {
        [JsonPropertyName("interval_")]
        public float Interval { get; set; }

        [JsonPropertyName("deltaTime_")]
        public float DeltaTime { get; set; }

        [JsonPropertyName("pos_")]
        public /* cVec4 */ Vector4 Pos { get; set; }

        [JsonPropertyName("rotY_")]
        public float RotY { get; set; }
    }
}
