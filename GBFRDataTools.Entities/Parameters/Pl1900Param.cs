using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1900Param : PlayerParameterInfo
{
    [JsonPropertyName("rushStartMotRate_")]
    public float RushStartMotRate { get; set; }

    [JsonPropertyName("ability_healRate")]
    public float Ability_healRate { get; set; }

    [JsonPropertyName("ability_HealBonusRate_")]
    public float Ability_HealBonusRate { get; set; }

    [JsonPropertyName("superModeTime_")]
    public float SuperModeTime { get; set; }

    [JsonPropertyName("attackRate_Lv1")]
    public float AttackRate_Lv1 { get; set; }

    [JsonPropertyName("attackRate_Lv2")]
    public float AttackRate_Lv2 { get; set; }

    [JsonPropertyName("attackRate_Lv3")]
    public float AttackRate_Lv3 { get; set; }

    [JsonPropertyName("attackRate_SuperMode")]
    public float AttackRate_SuperMode { get; set; }

    [JsonPropertyName("chargeRush_rushTime_lv1_")]
    public float ChargeRush_rushTime_lv1 { get; set; }

    [JsonPropertyName("chargeRush_rushTime_lv2_")]
    public float ChargeRush_rushTime_lv2 { get; set; }

    [JsonPropertyName("chargeRush_rushTime_lv3_")]
    public float ChargeRush_rushTime_lv3 { get; set; }

    [JsonPropertyName("chargeRush_rushTime_Limmit_")]
    public float ChargeRush_rushTime_Limmit { get; set; }

    [JsonPropertyName("ability_coverDist_")]
    public float Ability_coverDist { get; set; }

    [JsonPropertyName("ability_ChargeDmg_Percent_")]
    public float Ability_ChargeDmg_Percent { get; set; }

    [JsonPropertyName("ability_ChargeDmg_Interval_")]
    public float Ability_ChargeDmg_Interval { get; set; }

    [JsonPropertyName("superRushTime_")]
    public float SuperRushTime { get; set; }

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_")]
    public float LinkTimeAbilityCoolTimeBonus { get; set; }

    [JsonPropertyName("linkTimeAbilityCoolTimeBonus_Super_")]
    public float LinkTimeAbilityCoolTimeBonus_Super { get; set; }

    [JsonPropertyName("addBahamutLvList_")]
    public BindingList<BahamutLvPointParam> AddBahamutLvList { get; set; } = []; // std::vector<Pl1900Param::BahamutLvPointParam>

    [JsonPropertyName("finishFireLineCheckStart_")]
    public float FinishFireLineCheckStart { get; set; }

    [JsonPropertyName("finishFireLineCheckEnd_")]
    public float FinishFireLineCheckEnd { get; set; }

    [JsonPropertyName("finishFireCenterPos_")]
    public /* cVec4 */ Vector4 FinishFireCenterPos { get; set; }

    [JsonPropertyName("finishFireList_")]
    public BindingList<SuperFinishFireParam> FinishFireList { get; set; } = []; // std::vector<Pl1900Param::SuperFinishFireParam>

    public class BahamutLvPointParam // Pl1900Param::BahamutLvPointParam
    {
        [JsonPropertyName("actionName_")]
        public string ActionName { get; set; }

        [JsonPropertyName("actionId_")]
        public int ActionId { get; set; }

        [JsonPropertyName("point_")]
        public float Point { get; set; }
    }

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
