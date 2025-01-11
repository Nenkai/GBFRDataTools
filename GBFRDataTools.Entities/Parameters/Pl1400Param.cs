using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl1400Param : PlayerParameterInfo
{
    [JsonPropertyName("isUseNewGenziMesh_")]
    public bool IsUseNewGenziMesh { get; set; }

    [JsonPropertyName("limitButterflyMaxNum_")]
    public int LimitButterflyMaxNum { get; set; }

    [JsonPropertyName("butterFly_Num_")]
    public int ButterFly_Num { get; set; }

    [JsonPropertyName("butterFly_Time_")]
    public float ButterFly_Time { get; set; }

    [JsonPropertyName("butterFlt_AddAtkRate_")]
    public float ButterFlt_AddAtkRate { get; set; }

    [JsonPropertyName("butterFlt_AddBreakRate_")]
    public float ButterFlt_AddBreakRate { get; set; }

    [JsonPropertyName("kaguraRapidTime_")]
    public float KaguraRapidTime { get; set; }

    [JsonPropertyName("genziCharge_AtkDist")]
    public float GenziCharge_AtkDist { get; set; }

    [JsonPropertyName("genziCharge_ATkDir_")]
    public float GenziCharge_ATkDir { get; set; }

    [JsonPropertyName("genziCharge_ChargeTime_")]
    public float GenziCharge_ChargeTime { get; set; }

    [JsonPropertyName("genziCharge_Height_")]
    public float GenziCharge_Height { get; set; }

    [JsonPropertyName("genziCharge_AtkNum_Lv1")]
    public int GenziCharge_AtkNum_Lv1 { get; set; }

    [JsonPropertyName("genziCharge_AtkNum_Lv2")]
    public int GenziCharge_AtkNum_Lv2 { get; set; }

    [JsonPropertyName("genziCharge_AtkNum_Lv3")]
    public int GenziCharge_AtkNum_Lv3 { get; set; }

    [JsonPropertyName("genziCharge_AtkNum_Combo3Lv3")]
    public int GenziCharge_AtkNum_Combo3Lv3 { get; set; }

    [JsonPropertyName("atkBuff_BaseRate_")]
    public float AtkBuff_BaseRate { get; set; }

    [JsonPropertyName("atkBuff_AddRate_")]
    public float AtkBuff_AddRate { get; set; }

    [JsonPropertyName("atkBuff_BaseTime_")]
    public float AtkBuff_BaseTime { get; set; }

    [JsonPropertyName("atkBuff_AddTime_")]
    public float AtkBuff_AddTime { get; set; }

    [JsonPropertyName("doubleAtk_AtkRate_")]
    public float DoubleAtk_AtkRate { get; set; }

    [JsonPropertyName("doubleAtk_delayFrame_")]
    public int DoubleAtk_delayFrame { get; set; }

    [JsonPropertyName("defBuff_BaseRate_")]
    public float DefBuff_BaseRate { get; set; }

    [JsonPropertyName("defBuff_AddRate_")]
    public float DefBuff_AddRate { get; set; }

    [JsonPropertyName("defBuff_BaseTime_")]
    public float DefBuff_BaseTime { get; set; }

    [JsonPropertyName("defBuff_AddTime_")]
    public float DefBuff_AddTime { get; set; }

    [JsonPropertyName("defBuf_HealRate_")]
    public float DefBuf_HealRate { get; set; }

    [JsonPropertyName("defBuf_HealLimit_")]
    public float DefBuf_HealLimit { get; set; }

    [JsonPropertyName("hateForce_DebufBaseRate_")]
    public float HateForce_DebufBaseRate { get; set; }

    [JsonPropertyName("hateForce_DebufAddRate_")]
    public float HateForce_DebufAddRate { get; set; }

    [JsonPropertyName("genziVfxColor_")]
    public BindingList<float> GenziVfxColor { get; set; } = []; // std::array<Hw::cVec4,3>
}
