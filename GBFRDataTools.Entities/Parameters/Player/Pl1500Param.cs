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

public class Pl1500Param : PlayerParameterInfo
{
    [JsonPropertyName("styleLvMax_")]
    public int StyleLvMax { get; set; } = 10;

    [JsonPropertyName("styleLvMax_Unlock_")]
    public int StyleLvMax_Unlock { get; set; } = 9;

    [JsonPropertyName("addStyleLv_LinkAttackHit_")]
    public int AddStyleLv_LinkAttackHit { get; set; } = 3;

    [JsonPropertyName("addStyleLv_NormalFinish_")]
    public int AddStyleLv_NormalFinish { get; set; } = 5;

    [JsonPropertyName("addStyleLv_JustFinish_")]
    public int AddStyleLv_JustFinish { get; set; } = 7;

    [JsonPropertyName("autoDecreaseWaitSec_")]
    public float AutoDecreaseWaitSec { get; set; } = 3f;

    [JsonPropertyName("decreaseAccSec_")]
    public float DecreaseAccSec { get; set; } = 1.5f;

    [JsonPropertyName("styleLvGageMax_")]
    public float StyleLvGageMax { get; set; } = 1000f;

    [JsonPropertyName("styleGageDecrease_")]
    public float StyleGageDecrease { get; set; } = 5f;

    [JsonPropertyName("styleGageDecreaseAcc_")]
    public float StyleGageDecreaseAcc { get; set; } = 180f;

    [JsonPropertyName("styleLvAtkMin_")]
    public float StyleLvAtkMin { get; set; } = 1f;

    [JsonPropertyName("styleLvAtkMax_")]
    public float StyleLvAtkMax { get; set; } = 1.35f;

    [JsonPropertyName("fowardFist_AddMotionRate_Min_")]
    public float FowardFist_AddMotionRate_Min { get; set; } = 0f;

    [JsonPropertyName("fowardFist_AddMotionRate_Max_")]
    public float FowardFist_AddMotionRate_Max { get; set; } = 29f;

    [JsonPropertyName("fowardFistMotionRateCurve_")]
    public GuiImportableCurve<float> FowardFistMotionRateCurve { get; set; }

    [JsonPropertyName("styleLvAtkCurve_")]
    public GuiImportableCurve<float> StyleLvAtkCurve { get; set; }

    [JsonPropertyName("uniqueGeneCriticalRateMin_")]
    public float UniqueGeneCriticalRateMin { get; set; } = 0f;

    [JsonPropertyName("uniqueGeneCriticalRateMax_")]
    public float UniqueGeneCriticalRateMax { get; set; } = 10f;

    [JsonPropertyName("uniqueGeneCriticalCurve_")]
    public GuiImportableCurve<float> UniqueGeneCriticalCurve { get; set; }

    [JsonPropertyName("fowardFist_NoCargeAtkRate_")]
    public float FowardFist_NoCargeAtkRate { get; set; } = 0.09999999f;

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv0")]
    public float FowardFist_DamageLimitRate_Lv0 { get; set; } = 100f;

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv1_3")]
    public float FowardFist_DamageLimitRate_Lv1_3 { get; set; } = 200f;

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv4_6")]
    public float FowardFist_DamageLimitRate_Lv4_6 { get; set; } = 350f;

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv7_9")]
    public float FowardFist_DamageLimitRate_Lv7_9 { get; set; } = 600f;

    [JsonPropertyName("fowardFist_DamageLimitRate_LvMax")]
    public float FowardFist_DamageLimitRate_LvMax { get; set; } = 1000f;

    public Pl1500Param()
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
        LimitDamageRate = 5f;
        LimitSpecialArtsDamageRate = 0.6f;
        LimitAbilityDamageRate = 0.9f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 29999;
        DamageLimitSpecialAttack = 29999;
        DamageLimitAbility01 = 44999;
        DamageLimitAbility02 = 24999;
        DamageLimitAbility03 = 64999;
        DamageLimitAbility04 = 1;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 19999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 54999;
    }
}
