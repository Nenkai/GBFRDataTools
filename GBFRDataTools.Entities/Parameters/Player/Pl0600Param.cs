using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0600Param : PlayerParameterInfo
{
    [JsonPropertyName("attackRoseMotList_")]
    public BindingList<AttackRoseMotionData> AttackRoseMotList { get; set; } = []; // std::vector<Pl0600Param::AttackRoseMotionData>

    [JsonPropertyName("plantRoseMotList_")]
    public BindingList<PlantRoseMotionData> PlantRoseMotList { get; set; } = []; // std::vector<Pl0600Param::PlantRoseMotionData>

    [JsonPropertyName("roseAlphaRate_")]
    public float RoseAlphaRate { get; set; } = 1f;

    [JsonPropertyName("alphaFadeFrame_")]
    public int AlphaFadeFrame { get; set; } = 15;

    [JsonPropertyName("roseLifeTime_")]
    public float RoseLifeTime { get; set; } = 45f;

    [JsonPropertyName("forceLifeEndDist_")]
    public float ForceLifeEndDist { get; set; } = 120f;

    [JsonPropertyName("roseQuickPlantDist")]
    public float RoseQuickPlantDist { get; set; } = 5f;

    [JsonPropertyName("buffEffectDist_")]
    public float BuffEffectDist { get; set; } = 50f;

    [JsonPropertyName("buffEffectHeight_")]
    public float BuffEffectHeight { get; set; } = 2.5f;

    [JsonPropertyName("healBasePoint_")]
    public float HealBasePoint { get; set; } = 1.5f;

    [JsonPropertyName("healLevelUpRate_")]
    public float HealLevelUpRate { get; set; } = 0.5f;

    [JsonPropertyName("healLimit_")]
    public float HealLimit { get; set; } = 99999f;

    [JsonPropertyName("healLevelUpLimit_")]
    public float HealLevelUpLimit { get; set; } = 99999f;

    [JsonPropertyName("healIndirectPoint_")]
    public float HealIndirectPoint { get; set; } = 20f;

    [JsonPropertyName("defUpBasePoint_")]
    public float DefUpBasePoint { get; set; } = 0.06f;

    [JsonPropertyName("defUpLevelUpRate_")]
    public float DefUpLevelUpRate { get; set; } = 0.03f;

    [JsonPropertyName("defUpIndirectPoint_")]
    public float DefUpIndirectPoint { get; set; } = 20f;

    [JsonPropertyName("atkUpBasePoint_")]
    public float AtkUpBasePoint { get; set; } = 0.06f;

    [JsonPropertyName("atkUpLevelUpRate_")]
    public float AtkUpLevelUpRate { get; set; } = 0.03f;

    [JsonPropertyName("atkUpIndirectPoint_")]
    public float AtkUpIndirectPoint { get; set; } = 0.5f;

    [JsonPropertyName("rosePowerRate_")]
    public float RosePowerRate { get; set; } = 0.35f;

    [JsonPropertyName("rosePowerAddRate_")]
    public float RosePowerAddRate { get; set; } = 0.15f;

    [JsonPropertyName("roseBreakRate_")]
    public float RoseBreakRate { get; set; } = 0.2f;

    [JsonPropertyName("roseBreakAddRate_")]
    public float RoseBreakAddRate { get; set; } = 0.1f;

    [JsonPropertyName("rosePowerSpArts_")]
    public float RosePowerSpArts { get; set; } = 0f;

    [JsonPropertyName("autoRosePowerRate_")]
    public float AutoRosePowerRate { get; set; } = 0.2f;

    [JsonPropertyName("autoTPowerLevelUpRate_")]
    public float AutoTPowerLevelUpRate { get; set; } = 0.3f;

    [JsonPropertyName("buffAreaAttackInterval_")]
    public float BuffAreaAttackInterval { get; set; } = 3f;

    [JsonPropertyName("buffAreaSizeLv1_")]
    public float BuffAreaSizeLv1 { get; set; } = 3.7f;

    [JsonPropertyName("buffAreaSizeLv2_")]
    public float BuffAreaSizeLv2 { get; set; } = 5f;

    [JsonPropertyName("buffAreaSizeLv3_")]
    public float BuffAreaSizeLv3 { get; set; } = 7f;

    [JsonPropertyName("buffAreaSizeLv4_")]
    public float BuffAreaSizeLv4 { get; set; } = 9f;

    [JsonPropertyName("levelUpHitNum_Lv2")]
    public BindingList<int> LevelUpHitNum_Lv2 { get; set; } = [];

    [JsonPropertyName("levelUpHitNum_Lv3")]
    public BindingList<int> LevelUpHitNum_Lv3 { get; set; } = [];

    [JsonPropertyName("levelUpHitNum_Lv4")]
    public BindingList<int> LevelUpHitNum_Lv4 { get; set; } = [];

    [JsonPropertyName("spiralRoseAtkRate_")]
    public float SpiralRoseAtkRate { get; set; } = 0.45f;

    [JsonPropertyName("spiralRoseAddAtkRate_")]
    public float SpiralRoseAddAtkRate { get; set; } = 0.15f;

    [JsonPropertyName("spiralRoseBreakRate_")]
    public float SpiralRoseBreakRate { get; set; } = 0.2f;

    [JsonPropertyName("spiralRoseAddBreakRate_")]
    public float SpiralRoseAddBreakRate { get; set; } = 0.1f;

    [JsonPropertyName("spiralRoseSpArtsRate_")]
    public float SpiralRoseSpArtsRate { get; set; } = 0.1f;

    [JsonPropertyName("addLifeTime_")]
    public float AddLifeTime { get; set; } = 10f;

    [JsonPropertyName("ability_CombinationTime_")]
    public float Ability_CombinationTime { get; set; } = 15f;

    [JsonPropertyName("ability_InhaleTime_")]
    public float Ability_InhaleTime { get; set; } = 10f;

    [JsonPropertyName("ability_BarrierTime_")]
    public float Ability_BarrierTime { get; set; } = 20f;

    [JsonPropertyName("ability_BarrierAtkRate_")]
    public float Ability_BarrierAtkRate { get; set; } = 0.2f;

    [JsonPropertyName("damageCutIndirectPoint_")]
    public float DamageCutIndirectPoint { get; set; } = 10f;

    [JsonPropertyName("soundRoseVanishInterval_")]
    public float SoundRoseVanishInterval { get; set; } = 2f;

    [JsonPropertyName("backMoveRateXZ_")]
    public float BackMoveRateXZ { get; set; } = 1.8f;

    [JsonPropertyName("backMoveRateY_")]
    public float BackMoveRateY { get; set; } = 0.3f;

    [JsonPropertyName("attackWaitFrame_")]
    public float AttackWaitFrame { get; set; } = 100f;

    [JsonPropertyName("warpAtkRate_")]
    public float WarpAtkRate { get; set; } = 0.5f;

    [JsonPropertyName("warpAtkAddRate_")]
    public float WarpAtkAddRate { get; set; } = 0f;

    [JsonPropertyName("warpAtkBreakRate_")]
    public float WarpAtkBreakRate { get; set; } = 0.5f;

    [JsonPropertyName("warpAtkBreakAddRate_")]
    public float WarpAtkBreakAddRate { get; set; } = 0f;

    [JsonPropertyName("warpAtkSpArts_")]
    public float WarpAtkSpArts { get; set; } = 0.5f;

    [JsonPropertyName("rosePutParam_")]
    public Vector2[] RosePutParam { get; set; } = new Vector2[3]; // std::array<Hw::cVec2,3>

    public Pl0600Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 1.8f;
        HitSEMinBreak = 0f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 0.5f;
        LimitSpecialArtsDamageRate = 0.5f;
        LimitAbilityDamageRate = 0.7999999f;
        AiMoveNotargetDistance = 15f;
        DamageLimitNormalAttack = 9999;
        DamageLimitNormalAttack2 = 4999;
        DamageLimitSpecialAttack = 14999;
        DamageLimitAbility01 = 4999;
        DamageLimitAbility02 = 14999;
        DamageLimitAbility03 = 1;
        DamageLimitAbility04 = 4999;
        DamageLimitAbility05 = 1;
        DamageLimitAbility06 = 99999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 1;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 39999;
    }

    public class AttackRoseMotionData // Pl0600Param::AttackRoseMotionData
    {
        [JsonPropertyName("actionName_")]
        public string ActionName { get; set; }

        [JsonPropertyName("motionId_")]
        public string MotionId { get; set; }

        [JsonPropertyName("offsetPos_")]
        public /* cVec4 */ Vector4 OffsetPos { get; set; }

        [JsonPropertyName("attackRosePartsMotList_")]
        public BindingList<RosePartsMotionData> AttackRosePartsMotList { get; set; } = []; // std::vector<RosePartsMotionData>

    }

    public class PlantRoseMotionData // Pl0600Param::PlantRoseMotionData
    {
        [JsonPropertyName("actionName_")]
        public string ActionName { get; set; }

        [JsonPropertyName("motionId_")]
        public string MotionId { get; set; }

        [JsonPropertyName("plantRosePartsMotList_")]
        public BindingList<RosePartsMotionData> PlantRosePartsMotList { get; set; } = [];  // std::vector<RosePartsMotionData>
    }

    public class RosePartsMotionData // Pl0600Param::RosePartsMotionData
    {
        [JsonPropertyName("objId_")]
        public int ObjId { get; set; }

        [JsonPropertyName("animId_")]
        public string AnimId { get; set; }
    }
}
