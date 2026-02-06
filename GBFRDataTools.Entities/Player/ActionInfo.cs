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
    [Description("This will be the number used to refer to the action by other files or other actions in branching paths")]
    [JsonPropertyName("id_")]
    public int Id { get; set; } // Offset 0x8

    [Description("""
        Names the skill. This is only used for actual abilities, not normal actions.
        Example: "AB_PL0000_09" (this is Gran's 9th ability, which the ordering of abilities can be found by matching this against the Text file for the abilities, 
        or removing all selected abilities in game, and counting from top to bottom)
        """)]
    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; } // cyan::inplace_string<32> - Offset 0x10

    [JsonPropertyName("saveActionType_")]
    public int SaveActionType { get; set; } // Offset 0x2C0

    [Description("Controls specific traits for the action called.")]
    [JsonPropertyName("straddleFlagBit_")]
    public StraddleFlagBit StraddleFlagBit { get; set; } // Offset 0x40

    [Description("How many honors to give to the player upon casting the action.")]
    [JsonPropertyName("usePoint_")]
    public float UsePoint { get; set; } // Offset 0x44

    [JsonPropertyName("autoHormingType_")]
    public int AutoHormingType { get; set; } // Offset 0x48

    [JsonPropertyName("autoHormingOffsetDist_")]
    public float AutoHormingOffsetDist { get; set; } // Offset 0x4C

    [Description("The number of charges an ability can hold, like Lancelot's Lawinsturm.")]
    [JsonPropertyName("abilityStocks_")]
    public int AbilityStocks { get; set; } // Offset 0x50

    [JsonPropertyName("saveAbilityChargeType_")]
    public int SaveAbilityChargeType { get; set; } // Offset 0x2C4

    [Description("The cooldown of the ability.")]
    [JsonPropertyName("abilityChargeTime_")]
    public float AbilityChargeTime { get; set; } // Offset 0x58

    [Description("Minimum timer that will delay the ability cooldown from starting, this does not impact Cascade.")]
    [JsonPropertyName("abilityChargeDelayMin_")]
    public float AbilityChargeDelayMin { get; set; } // Offset 0x5C

    [Description("Maximum timer that will delay the ability cooldown from starting, this does not impact Cascade.")]
    [JsonPropertyName("abilityChargeDelayMax_")]
    public float AbilityChargeDelayMax { get; set; } // Offset 0x60

    [Description("When X is pressed during this action, so long as the flags are set to allow X presses, then the action listed in this will begin.")]
    [JsonPropertyName("branchXAtk_")]
    public int BranchXAtk { get; set; } // Offset 0x64

    [Description("When Y is pressed during this action, so long as the flags are set to allow X presses, then the action listed in this will begin.")]
    [JsonPropertyName("branchYAtk_")]
    public int BranchYAtk { get; set; } // Offset 0x68

    [Description("When X is pressed within a specified window in the flags for the action/motions, it will go to the action listed.")]
    [JsonPropertyName("branchXAtk_Just_")]
    public int BranchXAtk_Just { get; set; } // Offset 0x6C

    [Description("When Y is pressed within a specified window in the flags for the action/motions, it will go to the action listed.")]
    [JsonPropertyName("branchYAtk_Just_")]
    public int BranchYAtk_Just { get; set; } // Offset 0x70

    [Description("When X is held down before a specified time in the flags for the action, and continues to be held when the flag activates, this action will be called.")]
    [JsonPropertyName("branchXAtk_Hold_")]
    public int BranchXAtk_Hold { get; set; } // Offset 0x74

    [Description("When Y is held down before a specified time in the flags for the action, and continues to be held when the flag activates, this action will be called.")]
    [JsonPropertyName("branchYAtk_Hold_")]
    public int BranchYAtk_Hold { get; set; } // Offset 0x78

    [Description("Allows the action to automatically call another action after a hit is landed, depending on specific factors")]
    [JsonPropertyName("branchAtkHit_")]
    public int BranchAtkHit { get; set; } // Offset 0x7C

    [Description("Affects the distance the action is set to be called at by AI")]
    [JsonPropertyName("dist_")]
    public float Dist { get; set; } // Offset 0x80

    [JsonPropertyName("type_")]
    public int Type { get; set; } // Offset 0x84

    [Description("Controls how motions are handled when called by an action.")]
    [JsonPropertyName("controlTypeHash_")]
    public uint ControlTypeHash { get; set; } // Offset 0x2B8

    [JsonPropertyName("supportTypeHash_")]
    public uint SupportTypeHash { get; set; } // Offset 0x2BC

    [Description("A name assigned to the action by the devs, not referenced anywhere else.")]
    [JsonPropertyName("actionName_")]
    public string ActionName { get; set; } // Offset 0xC0

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId01_")]
    public string SaveMotId01 { get; set; } // Offset 0x268

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId02_")]
    public string SaveMotId02 { get; set; } // Offset 0x270

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId03_")]
    public string SaveMotId03 { get; set; } // Offset 0x278

    [JsonPropertyName("saveMotId04_")]
    public string SaveMotId04 { get; set; } // Offset 0x280

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId05_")]
    public string SaveMotId05 { get; set; } // Offset 0x288

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId06_")]
    public string SaveMotId06 { get; set; } // Offset 0x290

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId07_")]
    public string SaveMotId07 { get; set; } // Offset 0x298

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId08_")]
    public string SaveMotId08 { get; set; } // Offset 0x2A0

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId09_")]
    public string SaveMotId09 { get; set; } // Offset 0x2A8

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId10_")]
    public string SaveMotId10 { get; set; } // Offset 0x2B0

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork01_")]
    public float ActionFreeWork01 { get; set; } // Offset 0x220

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork02_")]
    public float ActionFreeWork02 { get; set; } // Offset 0x224

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork03_")]
    public float ActionFreeWork03 { get; set; } // Offset 0x228

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork04_")]
    public float ActionFreeWork04 { get; set; } // Offset 0x22C

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork05_")]
    public float ActionFreeWork05 { get; set; } // Offset 0x230

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork06_")]
    public float ActionFreeWork06 { get; set; } // Offset 0x234

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork07_")]
    public float ActionFreeWork07 { get; set; } // Offset 0x238

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork08_")]
    public float ActionFreeWork08 { get; set; } // Offset 0x23C

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork09_")]
    public float ActionFreeWork09 { get; set; } // Offset 0x240

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork10_")]
    public float ActionFreeWork10 { get; set; } // Offset 0x244

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork11_")]
    public float ActionFreeWork11 { get; set; } // Offset 0x248

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork12_")]
    public float ActionFreeWork12 { get; set; } // Offset 0x24C

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork13_")]
    public float ActionFreeWork13 { get; set; } // Offset 0x250

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork14_")]
    public float ActionFreeWork14 { get; set; } // Offset 0x254

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork15_")]
    public float ActionFreeWork15 { get; set; } // Offset 0x258

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork16_")]
    public float ActionFreeWork16 { get; set; } // Offset 0x25C

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork17_")]
    public float ActionFreeWork17 { get; set; } // Offset 0x260

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
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

    [Description("Always 1 seemingly.")]
    [JsonPropertyName("freeWork05_")]
    public float FreeWork05 { get; set; } // Offset 0x218

    [Description("Always 1 seemingly.")]
    [JsonPropertyName("freeWork06_")]
    public float FreeWork06 { get; set; } // Offset 0x21C

    [Description("""
        Can refer to the FSM associated with the action. 
        This is only used on some of the first characters designed, such as Captain, and is set within the executable. 
        Requires the correct flags during the action to call the FSM.
        """)]
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

    [Description("""
        Utilizes a hash and 6 values in an array format to state the buffs that will be applied to the character or team members when this player calls this action, 
        so long as the required flag is in any of the motions tied to the action. The first value in the array states how many buffs the game will attempt to give.
        """)]
    [JsonPropertyName("supportEffectList_")]
    public BindingList<SupportEffect> SupportEffectList { get; set; } = []; // std::vector<ActionInfo::SupportEffect> Offset 0x2C8

    [JsonPropertyName("uiIconCategory_")]
    public int UiIconCategory { get; set; } // Offset 0x9C

    [Description("BitFlag that affects how this action is called by AI when the skill is available. Each has specific requirements to be active depending on conditions set in the executable.")]
    [JsonPropertyName("actionCategory_")]
    public ActionCategory ActionCategory { get; set; } // Offset 0xA0

    [JsonPropertyName("isTriggerAttackHit_")]
    public bool IsTriggerAttackHit { get; set; } // Offset 0xA4

    [Description("Unused after version 1.3 of the game. Utilizes \"damageLimitDataIndex_\" instead.")]
    [JsonPropertyName("damageLimitType_")]
    public int DamageLimitType { get; set; } // Offset 0xA8

    [Description("Specifies the damage cap in the Parameter File's damage cap index that is associated with this action.")]
    [JsonPropertyName("damageLimitDataIndex_")]
    public int DamageLimitDataIndex { get; set; } // Offset 0xAC

    [Description("""
        Associates the action with the id assigned (Ie. \"AB_PL0000_09\" would be assigned \"8\"), 
        possibly not needed, changing it still allowed the action to function as intended
        """)]
    [JsonPropertyName("relatedAbilityType_")]
    public int RelatedAbilityType { get; set; } // Offset 0xB0

    [Description("Additional honors, possibly given on granting buffs to other players, not fully aware of how honors works")]
    [JsonPropertyName("indirectDamagePoint_")]
    public float IndirectDamagePoint { get; set; } // Offset 0xB4

    [Description("Unknown. True for Vane's Bubble")]
    [JsonPropertyName("isIndirectDamageAddMulti_")]
    public bool IsIndirectDamageAddMulti { get; set; } // Offset 0xB8

    [Description("""
        Requires more testing. 
        Disables players from casting a skill and having access to the skill follow-ups listed in BranchXAtk and BranchYAtk before the skill cooldown is used
        """)]
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

[Flags]
public enum ActionCategory : uint
{
    [Description("Gap Closer (Not Used)")]
    GapCloser = 1 << 0,

    [Description("Dodge/Parry (Not Used)")]
    DodgeParry = 1 << 1,

    [Description("Buff - Active if within distance specified in \"dist_\". Low Priority.")]
    Buff = 1 << 2,

    [Description("Debuff - Active if within distance specified in \"dist_\". Low Priority.")]
    Debuff = 1 << 3,

    [Description("Team Heal - Active depending on teammate HP values. High Priority.")]
    TeamHeal = 1 << 4,

    [Description("Damage - Active if within distance specified in \"dist_\". Low Priority.")]
    Damage = 1 << 5,

    [Description("Unused")]
    StunMaybe = 1 << 6,

    [Description("Ban Action (Crowd control like freeze) - Middle Priority.")]
    BanAction = 1 << 7,

    [Description("Self Heal - Active depending on AI HP value. High Priority.")]
    SelfHeal = 1 << 8,

    [Description("Cleanse - Active depending on if any character on the team has a debuff. High Priority.")]
    Cleanse = 1 << 9,

    [Description("Revive - Active depending on if any character on the team is down. High Priority.")]
    Revive = 1 << 10,
}

[Flags]
public enum StraddleFlagBit
{
    [Description("Bit0 - Enables BranchXAtk/BranchYAtk. If not active in an action, follow-ups will be the neutral X and Y presses for the character.")]
    Bit0 = 1 << 0,

    [Description("Bit1, unknown. Seen on Skills.")]
    Bit1 = 1 << 1,

    [Description("Bit2, unknown. Seen on Charge Attacks, as well as Attacks that lead into charge attacks.")]
    Bit2 = 1 << 2,

    [Description("Bit3 - Seen on Perfect Attacks. Not required for Perfect Attacks to function.")]
    Bit3 = 1 << 3,

    [Description("Bit4 - Seen on Id's Combo Finisher Slam, Talviyo, Flashing Void, and Narmaya's Stance Swap Attacks")]
    Bit4 = 1 << 4,

    [Description("Bit5 - Seen on Vaseraga's Air Normal Attacks and Cagliostro's Pain Train.")]
    Bit5 = 1 << 5,
}