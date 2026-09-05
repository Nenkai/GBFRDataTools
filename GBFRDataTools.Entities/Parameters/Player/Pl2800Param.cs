using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Weapon.We2100;
using GBFRDataTools.Entities.Player;

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

namespace GBFRDataTools.Entities.Parameters.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Pl2800Param : PlayerParameterInfo
{
    [JsonPropertyName("gageDecreasePoint_")]
    public float GageDecreasePoint { get; set; } = 0f; 

    [JsonPropertyName("autoDecreaseStopSec_")]
    public float AutoDecreaseStopSec { get; set; } = 10f; 

    [JsonPropertyName("linkTimeAutoIncreasePoint_")]
    public float LinkTimeAutoIncreasePoint { get; set; } = 300f; 

    [JsonPropertyName("linkAtkHitIncreasePoint_")]
    public float LinkAtkHitIncreasePoint { get; set; } = 150f;

    [JsonPropertyName("gageIncreaseDataList_")]
    public BindingList<GageAddParam> GageIncreaseDataList { get; set; } = []; // std::vector<Pl2800Param::GageAddParam>

    [JsonPropertyName("reverseAbilityDamageAtkBuff_")]
    public float ReverseAbilityDamageAtkBuff { get; set; } = 0.2f; 

    [JsonPropertyName("reverseAbilityDamageLimitBuff_")]
    public float ReverseAbilityDamageLimitBuff { get; set; } = 0.2f; 

    [JsonPropertyName("abilityPowerUpCount_")]
    public int AbilityPowerUpCount { get; set; } = 3; 

    [JsonPropertyName("stanceChangeInvincibleFrame_")]
    public int StanceChangeInvincibleFrame { get; set; } = 10; 

    [JsonPropertyName("stanceChangeGaugeIncrementBuff_")]
    public float StanceChangeGaugeIncrementBuff { get; set; } = 0f; 

    [JsonPropertyName("abilityMotionCameraInterFrame_")]
    public int AbilityMotionCameraInterFrame { get; set; } = 30; 

    [JsonPropertyName("gaugeDecayRate_")]
    public float GaugeDecayRate { get; set; } = 0f; 

    [JsonPropertyName("gaugeDecayMaxRate_Ability05_")]
    public float GaugeDecayMaxRate_Ability05 { get; set; } = 10f; 

    [JsonPropertyName("gaugeDecayRateRangeBeginCount_Ability05_")]
    public int GaugeDecayRateRangeBeginCount_Ability05 { get; set; } = 55; 

    [JsonPropertyName("gaugeDecayRateRangeEndCount_Ability05_")]
    public int GaugeDecayRateRangeEndCount_Ability05 { get; set; } = 80; 

    public Pl2800Param()
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
        DamageLimitMin = 999;
        DamageLimitMax = 999999;
        AtkRateMin = 0.1f;
        AtkRateMax = 100f;
        IsSetExtraWeaponMotion = true;
    }

    public class GageAddParam /* Pl2800Param::GageAddParam */
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; } 
    
        [JsonPropertyName("increasePoint_")]
        public float IncreasePoint { get; set; } 
    
        [JsonPropertyName("increasePointReverse_")]
        public float IncreasePointReverse { get; set; } 
    
        [JsonPropertyName("isIncreaseCurrentStanceOnly_")]
        public bool IsIncreaseCurrentStanceOnly { get; set; }
    }
}