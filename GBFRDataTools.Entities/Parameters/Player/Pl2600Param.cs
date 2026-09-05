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
public class Pl2600Param : PlayerParameterInfo
{
    [JsonPropertyName("passTimeSecMax_")]
    public float PassTimeSecMax { get; set; } = 0.25f; 

    [JsonPropertyName("passTimeSecMin_")]
    public float PassTimeSecMin { get; set; } = 0.0575f; 

    [JsonPropertyName("linkAttackHitGageIncreasePoint_")]
    public float LinkAttackHitGageIncreasePoint { get; set; } = 100f; 

    [JsonPropertyName("ability07GageIncreasePoint_")]
    public float Ability07GageIncreasePoint { get; set; } = 0f; 

    [JsonPropertyName("gageDecreasePoint_")]
    public float GageDecreasePoint { get; set; } = 0.55f; 

    [JsonPropertyName("autoDecreaseStopSec_")]
    public float AutoDecreaseStopSec { get; set; } = 1f;

    [JsonPropertyName("gageIncreaseDataList_")]
    public BindingList<GageAddParam> GageIncreaseDataList { get; set; } = []; // std::vector<Pl2600Param::GageAddParam>

    [JsonPropertyName("slipDamageCycleSec_")]
    public float SlipDamageCycleSec { get; set; } = 5f; 

    [JsonPropertyName("slipDamageHpPersantage_")]
    public float SlipDamageHpPersantage { get; set; } = 1f; 

    [JsonPropertyName("amplifyDamageRate_")]
    public float AmplifyDamageRate { get; set; } = 10f; 

    [JsonPropertyName("bonusDamageRate_")]
    public float BonusDamageRate { get; set; } = 5f; 

    [JsonPropertyName("damageCutRate_")]
    public float DamageCutRate { get; set; } = 20f; 

    [JsonPropertyName("regeneratePower_")]
    public float RegeneratePower { get; set; } = 2.5f; 

    [JsonPropertyName("drainHealPower_")]
    public float DrainHealPower { get; set; } = 0.1f; 

    [JsonPropertyName("clockBuffDisableSec_")]
    public float ClockBuffDisableSec { get; set; } = 10f; 

    [JsonPropertyName("clockHandsUpdateWaitFrame_")]
    public int ClockHandsUpdateWaitFrame { get; set; } = 10; 

    [JsonPropertyName("ability08IncreaseRate01_AmplifyDamage_")]
    public float Ability08IncreaseRate01_AmplifyDamage { get; set; } = 5f; 

    [JsonPropertyName("ability08IncreaseRate01_MultiAtk_")]
    public float Ability08IncreaseRate01_MultiAtk { get; set; } = 2.5f; 

    [JsonPropertyName("ability08IncreaseRate02_Regenerate_")]
    public float Ability08IncreaseRate02_Regenerate { get; set; } = 2.5f; 

    [JsonPropertyName("ability08IncreaseRate02_Drain_")]
    public float Ability08IncreaseRate02_Drain { get; set; } = 10f; 

    [JsonPropertyName("ability08IncreaseRate03_")]
    public float Ability08IncreaseRate03 { get; set; } = 10f; 

    [JsonPropertyName("embrasqueSwordGaugeDecayRate_")]
    public float EmbrasqueSwordGaugeDecayRate { get; set; } = 25f; 

    public Pl2600Param()
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
        IsSetExtraWeaponMotion = false;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GageAddParam /* Pl2600Param::GageAddParam */
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; }
    
        [JsonPropertyName("motionId_")]
        public int MotionId { get; set; }
    
        [JsonPropertyName("increasePoint_")]
        public float IncreasePoint { get; set; }
    
        [JsonPropertyName("isSingleEnemy_")]
        public bool IsSingleEnemy { get; set; }
    }
}