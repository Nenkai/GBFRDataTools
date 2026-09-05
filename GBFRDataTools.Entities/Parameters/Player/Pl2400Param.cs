using GBFRDataTools.Entities.Base;
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

using static GBFRDataTools.Entities.Parameters.Player.Pl2200Param;

namespace GBFRDataTools.Entities.Parameters.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Pl2400Param : PlayerParameterInfo
{
    [JsonPropertyName("linkAttackHitGaugeIncreasePoint_")]
    public float LinkAttackHitGaugeIncreasePoint { get; set; } = 100f;

    [JsonPropertyName("chargeParryGaugeIncreasePointNormal_")]
    public float ChargeParryGaugeIncreasePointNormal { get; set; } = 800f;

    [JsonPropertyName("chargeParryGaugeIncreasePointSuper_")]
    public float ChargeParryGaugeIncreasePointSuper { get; set; } = 150f;

    [JsonPropertyName("gaugeDecreaseParams_")]
    [Editable(false)]
    public BindingList<GaugeDecreaseParams_> GaugeDecreaseParams { get; set; } = [.. Enumerable.Repeat(new GaugeDecreaseParams_(), 2)]; // std::array<Pl2400Param::GaugeDecreaseParams,2>

    [JsonPropertyName("gaugeExStopTime_Ability8_")]
    public float GaugeExStopTime_Ability8 { get; set; } = 0f;

    [JsonPropertyName("superModeAtkRate_")]
    public float SuperModeAtkRate { get; set; } = 0.1999999f;

    [JsonPropertyName("gSwingForceLvUpHitCount1to2_")]
    public int GSwingForceLvUpHitCount1to2 { get; set; } = 0;

    [JsonPropertyName("gSwingForceLvUpHitCount2to3_")]
    public int GSwingForceLvUpHitCount2to3 { get; set; } = 0;

    [JsonPropertyName("gSwingForceLvUpHitCount3to4_")]
    public int GSwingForceLvUpHitCount3to4 { get; set; } = 0;

    [JsonPropertyName("gSwingLvUpSuperModeExHitCount1to2_")]
    public int GSwingLvUpSuperModeExHitCount1to2 { get; set; } = 0;

    [JsonPropertyName("gSwingLvUpSuperModeExHitCount2to3_")]
    public int GSwingLvUpSuperModeExHitCount2to3 { get; set; } = 0;

    [JsonPropertyName("gSwingLvUpSuperModeExHitCount3to4_")]
    public int GSwingLvUpSuperModeExHitCount3to4 { get; set; } = 0;

    [JsonPropertyName("gSwingLvUpSuperModeExHitCount4toF_")]
    public int GSwingLvUpSuperModeExHitCount4toF { get; set; } = 0;

    [JsonPropertyName("gaugeIncreaseDataList_")]
    public BindingList<GaugeAddParam> GaugeIncreaseDataList { get; set; } = []; // std::vector<Pl2400Param::GaugeAddParam>

    [JsonPropertyName("gaugeIncreaseMaxRate_Ability6_")]
    public float GaugeIncreaseMaxRate_Ability6 { get; set; } = 14.99998f;

    [JsonPropertyName("gaugeIncreaseRateRangeBeginCount_Ability6_")]
    public int GaugeIncreaseRateRangeBeginCount_Ability6 { get; set; } = 10;

    [JsonPropertyName("gaugeIncreaseRateRangeEndCount_Ability6_")]
    public int GaugeIncreaseRateRangeEndCount_Ability6 { get; set; } = 20;

    [JsonPropertyName("gComboJustCountForEnhancedGSwing_")]
    public int GComboJustCountForEnhancedGSwing { get; set; } = 5;

    [JsonPropertyName("gComboJustAtkRate_")]
    public float GComboJustAtkRate { get; set; } = 0.2f;

    [JsonPropertyName("guardPointDamageCutRate_")]
    public float GuardPointDamageCutRate { get; set; } = 0.6f;

    [JsonPropertyName("guardPointKnockBackRate_")]
    public float GuardPointKnockBackRate { get; set; } = 0.5f;

    [JsonPropertyName("gSwingParams_")]
    [Editable(false)]
    public BindingList<GSwingParams_> GSwingParams { get; set; } = [.. Enumerable.Repeat(new GSwingParams_(), 4)]; // std::array<Pl2400Param::GSwingParams,4>

    [JsonPropertyName("enhancedGSwingParams_")]
    [Editable(false)]
    public GSwingParams_ EnhancedGSwingParams { get; set; } = new();

    [JsonPropertyName("gSwingJustReleaseTime_")]
    public float GSwingJustReleaseTime { get; set; } = 0.6f;

    public Pl2400Param()
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
    public class GaugeAddParam /* Pl2400Param::GaugeAddParam */
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; }
    
        [JsonPropertyName("motionId_")]
        public int MotionId { get; set; }

        [JsonPropertyName("increasePointNormal_")]
        public float IncreasePointNormal { get; set; }
    
        [JsonPropertyName("increasePointSuper_")]
        public float IncreasePointSuper { get; set; }
    
        [JsonPropertyName("activatedNormal_")]
        public bool ActivatedNormal { get; set; }
    
        [JsonPropertyName("activatedSuper_")]
        public bool ActivatedSuper { get; set; }
    
        [JsonPropertyName("motionLoopedNormal_")]
        public bool MotionLoopedNormal { get; set; }
    
        [JsonPropertyName("motionLoopedSuper_")]
        public bool MotionLoopedSuper { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GaugeDecreaseParams_ /* Pl2400Param::GaugeDecreaseParams */
    {
        [JsonPropertyName("gaugeDecreasePoint_")]
        public float GaugeDecreasePoint { get; set; }
    
        [JsonPropertyName("autoDecreaseStopSecForStartSPMode_")]
        public float AutoDecreaseStopSecForStartSPMode { get; set; }
    
        [JsonPropertyName("autoDecreaseStopSecForAttackHit_")]
        public float AutoDecreaseStopSecForAttackHit { get; set; }
    
        [JsonPropertyName("gaugeDecreaseSpeedUpStartTime_")]
        public float GaugeDecreaseSpeedUpStartTime { get; set; }
    
        [JsonPropertyName("gaugeDecreaseSpeedUpMaxDuration_")]
        public float GaugeDecreaseSpeedUpMaxDuration { get; set; }
    
        [JsonPropertyName("gaugeDecreaseSpeedUpRate_")]
        public float GaugeDecreaseSpeedUpRate { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GSwingParams_ /* Pl2400Param::GSwingParams */
    {
        [JsonPropertyName("addMovementRate_")]
        public float AddMovementRate { get; set; }
    
        [JsonPropertyName("addAtkRate_")]
        public float AddAtkRate { get; set; }
    }
}
