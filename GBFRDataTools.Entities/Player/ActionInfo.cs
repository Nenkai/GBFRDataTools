using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Player;

public class ActionInfo
{
    [JsonPropertyName("id_")]
    public int Id { get; set; } // Offset 0x8

    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; } // cyan::inplace_string<32> - Offset 0x10

    [JsonPropertyName("saveActionType_")]
    public int SaveActionType { get; set; } // Offset 0x2C0

    [JsonPropertyName("straddleFlagBit_")]
    public uint StraddleFlagBit { get; set; } // Offset 0x40

    [JsonPropertyName("usePoint_")]
    public float UsePoint { get; set; } // Offset 0x44

    [JsonPropertyName("autoHormingType_")]
    public int AutoHormingType { get; set; } // Offset 0x48

    [JsonPropertyName("autoHormingOffsetDist_")]
    public float AutoHormingOffsetDist { get; set; } // Offset 0x4C

    [JsonPropertyName("abilityStocks_")]
    public int AbilityStocks { get; set; } // Offset 0x50

    [JsonPropertyName("saveAbilityChargeType_")]
    public int SaveAbilityChargeType { get; set; } // Offset 0x2C4

    [JsonPropertyName("abilityChargeTime_")]
    public float AbilityChargeTime { get; set; } // Offset 0x58

    [JsonPropertyName("abilityChargeDelayMin_")]
    public float AbilityChargeDelayMin { get; set; } // Offset 0x5C

    [JsonPropertyName("abilityChargeDelayMax_")]
    public float AbilityChargeDelayMax { get; set; } // Offset 0x60

    [JsonPropertyName("branchXAtk_")]
    public int BranchXAtk { get; set; } // Offset 0x64

    [JsonPropertyName("branchYAtk_")]
    public int BranchYAtk { get; set; } // Offset 0x68

    [JsonPropertyName("branchXAtk_Just_")]
    public int BranchXAtk_Just { get; set; } // Offset 0x6C

    [JsonPropertyName("branchYAtk_Just_")]
    public int BranchYAtk_Just { get; set; } // Offset 0x70

    [JsonPropertyName("branchXAtk_Hold_")]
    public int BranchXAtk_Hold { get; set; } // Offset 0x74

    [JsonPropertyName("branchYAtk_Hold_")]
    public int BranchYAtk_Hold { get; set; } // Offset 0x78

    [JsonPropertyName("branchAtkHit_")]
    public int BranchAtkHit { get; set; } // Offset 0x7C

    [JsonPropertyName("dist_")]
    public float Dist { get; set; } // Offset 0x80

    [JsonPropertyName("type_")]
    public int Type { get; set; } // Offset 0x84

    [JsonPropertyName("controlTypeHash_")]
    public uint ControlTypeHash { get; set; } // Offset 0x2B8

    [JsonPropertyName("supportTypeHash_")]
    public uint SupportTypeHash { get; set; } // Offset 0x2BC

    [JsonPropertyName("actionName_")]
    public string ActionName { get; set; } // Offset 0xC0

    [JsonPropertyName("saveMotId01_")]
    public string SaveMotId01 { get; set; } // Offset 0x268

    [JsonPropertyName("saveMotId02_")]
    public string SaveMotId02 { get; set; } // Offset 0x270

    [JsonPropertyName("saveMotId03_")]
    public string SaveMotId03 { get; set; } // Offset 0x278

    [JsonPropertyName("saveMotId04_")]
    public string SaveMotId04 { get; set; } // Offset 0x280

    [JsonPropertyName("saveMotId05_")]
    public string SaveMotId05 { get; set; } // Offset 0x288

    [JsonPropertyName("saveMotId06_")]
    public string SaveMotId06 { get; set; } // Offset 0x290

    [JsonPropertyName("saveMotId07_")]
    public string SaveMotId07 { get; set; } // Offset 0x298

    [JsonPropertyName("saveMotId08_")]
    public string SaveMotId08 { get; set; } // Offset 0x2A0

    [JsonPropertyName("saveMotId09_")]
    public string SaveMotId09 { get; set; } // Offset 0x2A8

    [JsonPropertyName("saveMotId10_")]
    public string SaveMotId10 { get; set; } // Offset 0x2B0

    [JsonPropertyName("actionFreeWork01_")]
    public float ActionFreeWork01 { get; set; } // Offset 0x220

    [JsonPropertyName("actionFreeWork02_")]
    public float ActionFreeWork02 { get; set; } // Offset 0x224

    [JsonPropertyName("actionFreeWork03_")]
    public float ActionFreeWork03 { get; set; } // Offset 0x228

    [JsonPropertyName("actionFreeWork04_")]
    public float ActionFreeWork04 { get; set; } // Offset 0x22C

    [JsonPropertyName("actionFreeWork05_")]
    public float ActionFreeWork05 { get; set; } // Offset 0x230

    [JsonPropertyName("actionFreeWork06_")]
    public float ActionFreeWork06 { get; set; } // Offset 0x234

    [JsonPropertyName("actionFreeWork07_")]
    public float ActionFreeWork07 { get; set; } // Offset 0x238

    [JsonPropertyName("actionFreeWork08_")]
    public float ActionFreeWork08 { get; set; } // Offset 0x23C

    [JsonPropertyName("actionFreeWork09_")]
    public float ActionFreeWork09 { get; set; } // Offset 0x240

    [JsonPropertyName("actionFreeWork10_")]
    public float ActionFreeWork10 { get; set; } // Offset 0x244

    [JsonPropertyName("actionFreeWork11_")]
    public float ActionFreeWork11 { get; set; } // Offset 0x248

    [JsonPropertyName("actionFreeWork12_")]
    public float ActionFreeWork12 { get; set; } // Offset 0x24C

    [JsonPropertyName("actionFreeWork13_")]
    public float ActionFreeWork13 { get; set; } // Offset 0x250

    [JsonPropertyName("actionFreeWork14_")]
    public float ActionFreeWork14 { get; set; } // Offset 0x254

    [JsonPropertyName("actionFreeWork15_")]
    public float ActionFreeWork15 { get; set; } // Offset 0x258

    [JsonPropertyName("actionFreeWork16_")]
    public float ActionFreeWork16 { get; set; } // Offset 0x25C

    [JsonPropertyName("actionFreeWork17_")]
    public float ActionFreeWork17 { get; set; } // Offset 0x260

    [JsonPropertyName("actionFreeWork18_")]
    public float ActionFreeWork18 { get; set; } // Offset 0x264

    [JsonPropertyName("freeWork01_")]
    public float FreeWork01 { get; set; } // Offset 0x208

    [JsonPropertyName("freeWork02_")]
    public float FreeWork02 { get; set; } // Offset 0x20C

    [JsonPropertyName("freeWork03_")]
    public float FreeWork03 { get; set; } // Offset 0x210

    [JsonPropertyName("freeWork04_")]
    public float FreeWork04 { get; set; } // Offset 0x214

    [JsonPropertyName("freeWork05_")]
    public float FreeWork05 { get; set; } // Offset 0x218

    [JsonPropertyName("freeWork06_")]
    public float FreeWork06 { get; set; } // Offset 0x21C

    [JsonPropertyName("bulletType_")]
    public int BulletType { get; set; } // Offset 0x88

    [JsonPropertyName("bulletFreeWork01_")]
    public int BulletFreeWork01 { get; set; } // Offset 0x8C

    [JsonPropertyName("bulletFreeWork02_")]
    public int BulletFreeWork02 { get; set; } // Offset 0x90

    [JsonPropertyName("bulletFreeWork03_")]
    public int BulletFreeWork03 { get; set; } // Offset 0x94

    [JsonPropertyName("bulletFreeWork04_")]
    public int BulletFreeWork04 { get; set; } // Offset 0x98

    [JsonPropertyName("supportEffectList_")]
    public BindingList<SupportEffect> SupportEffectList { get; set; } = []; // std::vector<ActionInfo::SupportEffect> Offset 0x2C8

    [JsonPropertyName("uiIconCategory_")]
    public int UiIconCategory { get; set; } // Offset 0x9C

    [JsonPropertyName("actionCategory_")]
    public uint ActionCategory { get; set; } // Offset 0xA0

    [JsonPropertyName("isTriggerAttackHit_")]
    public bool IsTriggerAttackHit { get; set; } // Offset 0xA4

    [JsonPropertyName("damageLimitType_")]
    public int DamageLimitType { get; set; } // Offset 0xA8

    [JsonPropertyName("damageLimitDataIndex_")]
    public int DamageLimitDataIndex { get; set; } // Offset 0xAC

    [JsonPropertyName("relatedAbilityType_")]
    public int RelatedAbilityType { get; set; } // Offset 0xB0

    [JsonPropertyName("indirectDamagePoint_")]
    public float IndirectDamagePoint { get; set; } // Offset 0xB4

    [JsonPropertyName("isIndirectDamageAddMulti_")]
    public bool IsIndirectDamageAddMulti { get; set; } // Offset 0xB8

    [JsonPropertyName("isCheckComboCutAbility_")]
    public bool IsCheckComboCutAbility { get; set; } // Offset 0xB9

    public ActionInfo()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SupportEffect
    {
        public uint Hash { get; set; }
        public float Value1 { get; set; }
        public float Value2 { get; set; }
        public float Value3 { get; set; }
        public float Value4 { get; set; }
        public float Value5 { get; set; }
        public float Value6 { get; set; }
    }
}
