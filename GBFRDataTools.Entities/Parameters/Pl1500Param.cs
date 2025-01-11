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

public class Pl1500Param : PlayerParameterInfo
{
    [JsonPropertyName("styleLvMax_")]
    public int StyleLvMax { get; set; }

    [JsonPropertyName("styleLvMax_Unlock_")]
    public int StyleLvMax_Unlock { get; set; }

    [JsonPropertyName("addStyleLv_LinkAttackHit_")]
    public int AddStyleLv_LinkAttackHit { get; set; }

    [JsonPropertyName("addStyleLv_NormalFinish_")]
    public int AddStyleLv_NormalFinish { get; set; }

    [JsonPropertyName("addStyleLv_JustFinish_")]
    public int AddStyleLv_JustFinish { get; set; }

    [JsonPropertyName("autoDecreaseWaitSec_")]
    public float AutoDecreaseWaitSec { get; set; }

    [JsonPropertyName("decreaseAccSec_")]
    public float DecreaseAccSec { get; set; }

    [JsonPropertyName("styleLvGageMax_")]
    public float StyleLvGageMax { get; set; }

    [JsonPropertyName("styleGageDecrease_")]
    public float StyleGageDecrease { get; set; }

    [JsonPropertyName("styleGageDecreaseAcc_")]
    public float StyleGageDecreaseAcc { get; set; }

    [JsonPropertyName("styleLvAtkMin_")]
    public float StyleLvAtkMin { get; set; }

    [JsonPropertyName("styleLvAtkMax_")]
    public float StyleLvAtkMax { get; set; }

    [JsonPropertyName("fowardFist_AddMotionRate_Min_")]
    public float FowardFist_AddMotionRate_Min { get; set; }

    [JsonPropertyName("fowardFist_AddMotionRate_Max_")]
    public float FowardFist_AddMotionRate_Max { get; set; }

    [JsonPropertyName("fowardFistMotionRateCurve_")]
    public GuiImportableCurve<float> FowardFistMotionRateCurve { get; set; }

    [JsonPropertyName("styleLvAtkCurve_")]
    public GuiImportableCurve<float> StyleLvAtkCurve { get; set; }

    [JsonPropertyName("uniqueGeneCriticalRateMin_")]
    public float UniqueGeneCriticalRateMin { get; set; }

    [JsonPropertyName("uniqueGeneCriticalRateMax_")]
    public float UniqueGeneCriticalRateMax { get; set; }

    [JsonPropertyName("uniqueGeneCriticalCurve_")]
    public GuiImportableCurve<float> UniqueGeneCriticalCurve { get; set; }

    [JsonPropertyName("fowardFist_NoCargeAtkRate_")]
    public float FowardFist_NoCargeAtkRate { get; set; }

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv0")]
    public float FowardFist_DamageLimitRate_Lv0 { get; set; }

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv1_3")]
    public float FowardFist_DamageLimitRate_Lv1_3 { get; set; }

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv4_6")]
    public float FowardFist_DamageLimitRate_Lv4_6 { get; set; }

    [JsonPropertyName("fowardFist_DamageLimitRate_Lv7_9")]
    public float FowardFist_DamageLimitRate_Lv7_9 { get; set; }

    [JsonPropertyName("fowardFist_DamageLimitRate_LvMax")]
    public float FowardFist_DamageLimitRate_LvMax { get; set; }
}
