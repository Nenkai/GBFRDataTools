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

public class Pl0600Param : PlayerParameterInfo
{
    [JsonPropertyName("attackRoseMotList_")]
    public BindingList<AttackRoseMotionData> AttackRoseMotList { get; set; } = []; // std::vector<Pl0600Param::AttackRoseMotionData>

    [JsonPropertyName("plantRoseMotList_")]
    public BindingList<PlantRoseMotionData> PlantRoseMotList { get; set; } = []; // std::vector<Pl0600Param::PlantRoseMotionData>

    [JsonPropertyName("roseAlphaRate_")]
    public float RoseAlphaRate { get; set; }

    [JsonPropertyName("alphaFadeFrame_")]
    public int AlphaFadeFrame { get; set; }

    [JsonPropertyName("roseLifeTime_")]
    public float RoseLifeTime { get; set; }

    [JsonPropertyName("forceLifeEndDist_")]
    public float ForceLifeEndDist { get; set; }

    [JsonPropertyName("roseQuickPlantDist")]
    public float RoseQuickPlantDist { get; set; }

    [JsonPropertyName("buffEffectDist_")]
    public float BuffEffectDist { get; set; }

    [JsonPropertyName("buffEffectHeight_")]
    public float BuffEffectHeight { get; set; }

    [JsonPropertyName("healBasePoint_")]
    public float HealBasePoint { get; set; }

    [JsonPropertyName("healLevelUpRate_")]
    public float HealLevelUpRate { get; set; }

    [JsonPropertyName("healLimit_")]
    public float HealLimit { get; set; }

    [JsonPropertyName("healLevelUpLimit_")]
    public float HealLevelUpLimit { get; set; }

    [JsonPropertyName("healIndirectPoint_")]
    public float HealIndirectPoint { get; set; }

    [JsonPropertyName("defUpBasePoint_")]
    public float DefUpBasePoint { get; set; }

    [JsonPropertyName("defUpLevelUpRate_")]
    public float DefUpLevelUpRate { get; set; }

    [JsonPropertyName("defUpIndirectPoint_")]
    public float DefUpIndirectPoint { get; set; }

    [JsonPropertyName("atkUpBasePoint_")]
    public float AtkUpBasePoint { get; set; }

    [JsonPropertyName("atkUpLevelUpRate_")]
    public float AtkUpLevelUpRate { get; set; }

    [JsonPropertyName("atkUpIndirectPoint_")]
    public float AtkUpIndirectPoint { get; set; }

    [JsonPropertyName("rosePowerRate_")]
    public float RosePowerRate { get; set; }

    [JsonPropertyName("rosePowerAddRate_")]
    public float RosePowerAddRate { get; set; }

    [JsonPropertyName("roseBreakRate_")]
    public float RoseBreakRate { get; set; }

    [JsonPropertyName("roseBreakAddRate_")]
    public float RoseBreakAddRate { get; set; }

    [JsonPropertyName("rosePowerSpArts_")]
    public float RosePowerSpArts { get; set; }

    [JsonPropertyName("autoRosePowerRate_")]
    public float AutoRosePowerRate { get; set; }

    [JsonPropertyName("autoTPowerLevelUpRate_")]
    public float AutoTPowerLevelUpRate { get; set; }

    [JsonPropertyName("buffAreaAttackInterval_")]
    public float BuffAreaAttackInterval { get; set; }

    [JsonPropertyName("buffAreaSizeLv1_")]
    public float BuffAreaSizeLv1 { get; set; }

    [JsonPropertyName("buffAreaSizeLv2_")]
    public float BuffAreaSizeLv2 { get; set; }

    [JsonPropertyName("buffAreaSizeLv3_")]
    public float BuffAreaSizeLv3 { get; set; }

    [JsonPropertyName("buffAreaSizeLv4_")]
    public float BuffAreaSizeLv4 { get; set; }

    [JsonPropertyName("levelUpHitNum_Lv2")]
    public BindingList<int> LevelUpHitNum_Lv2 { get; set; } = [];

    [JsonPropertyName("levelUpHitNum_Lv3")]
    public BindingList<int> LevelUpHitNum_Lv3 { get; set; } = [];

    [JsonPropertyName("levelUpHitNum_Lv4")]
    public BindingList<int> LevelUpHitNum_Lv4 { get; set; } = [];

    [JsonPropertyName("spiralRoseAtkRate_")]
    public float SpiralRoseAtkRate { get; set; }

    [JsonPropertyName("spiralRoseAddAtkRate_")]
    public float SpiralRoseAddAtkRate { get; set; }

    [JsonPropertyName("spiralRoseBreakRate_")]
    public float SpiralRoseBreakRate { get; set; }

    [JsonPropertyName("spiralRoseAddBreakRate_")]
    public float SpiralRoseAddBreakRate { get; set; }

    [JsonPropertyName("spiralRoseSpArtsRate_")]
    public float SpiralRoseSpArtsRate { get; set; }

    [JsonPropertyName("addLifeTime_")]
    public float AddLifeTime { get; set; }

    [JsonPropertyName("ability_CombinationTime_")]
    public float Ability_CombinationTime { get; set; }

    [JsonPropertyName("ability_InhaleTime_")]
    public float Ability_InhaleTime { get; set; }

    [JsonPropertyName("ability_BarrierTime_")]
    public float Ability_BarrierTime { get; set; }

    [JsonPropertyName("ability_BarrierAtkRate_")]
    public float Ability_BarrierAtkRate { get; set; }

    [JsonPropertyName("damageCutIndirectPoint_")]
    public float DamageCutIndirectPoint { get; set; }

    [JsonPropertyName("soundRoseVanishInterval_")]
    public float SoundRoseVanishInterval { get; set; }

    [JsonPropertyName("backMoveRateXZ_")]
    public float BackMoveRateXZ { get; set; }

    [JsonPropertyName("backMoveRateY_")]
    public float BackMoveRateY { get; set; }

    [JsonPropertyName("attackWaitFrame_")]
    public float AttackWaitFrame { get; set; }

    [JsonPropertyName("warpAtkRate_")]
    public float WarpAtkRate { get; set; }

    [JsonPropertyName("warpAtkAddRate_")]
    public float WarpAtkAddRate { get; set; }

    [JsonPropertyName("warpAtkBreakRate_")]
    public float WarpAtkBreakRate { get; set; }

    [JsonPropertyName("warpAtkBreakAddRate_")]
    public float WarpAtkBreakAddRate { get; set; }

    [JsonPropertyName("warpAtkSpArts_")]
    public float WarpAtkSpArts { get; set; }

    [JsonPropertyName("rosePutParam_")]
    public BindingList<Vector4> RosePutParam { get; set; } = []; // std::array<Hw::cVec2,3>

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
