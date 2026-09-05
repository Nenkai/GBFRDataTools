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
    public int Id { get; set; }

    [Description("""
        Names the skill. This is only used for actual abilities, not normal actions.
        Example: "AB_PL0000_09" (this is Gran's 9th ability, which the ordering of abilities can be found by matching this against the Text file for the abilities, 
        or removing all selected abilities in game, and counting from top to bottom)
        """)]
    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; } // cyan::inplace_string<32>

    [JsonPropertyName("saveActionType_")]
    public int SaveActionType { get; set; }

    [Description("Controls specific traits for the action called.")]
    [JsonPropertyName("straddleFlagBit_")]
    public StraddleFlagBit StraddleFlagBit { get; set; }

    [Description("How many honors to give to the player upon casting the action.")]
    [JsonPropertyName("usePoint_")]
    public float UsePoint { get; set; }

    [JsonPropertyName("autoHormingType_")]
    public int AutoHormingType { get; set; }

    [JsonPropertyName("autoHormingOffsetDist_")]
    public float AutoHormingOffsetDist { get; set; }

    [Description("The number of charges an ability can hold, like Lancelot's Lawinsturm.")]
    [JsonPropertyName("abilityStocks_")]
    public int AbilityStocks { get; set; }

    [JsonPropertyName("saveAbilityChargeType_")]
    public int SaveAbilityChargeType { get; set; }

    [Description("The cooldown of the ability.")]
    [JsonPropertyName("abilityChargeTime_")]
    public float AbilityChargeTime { get; set; }

    [Description("Minimum timer that will delay the ability cooldown from starting, this does not impact Cascade.")]
    [JsonPropertyName("abilityChargeDelayMin_")]
    public float AbilityChargeDelayMin { get; set; }

    [Description("Maximum timer that will delay the ability cooldown from starting, this does not impact Cascade.")]
    [JsonPropertyName("abilityChargeDelayMax_")]
    public float AbilityChargeDelayMax { get; set; }

    [Description("When X is pressed during this action, so long as the flags are set to allow X presses, then the action listed in this will begin.")]
    [JsonPropertyName("branchXAtk_")]
    public int BranchXAtk { get; set; }

    [Description("When Y is pressed during this action, so long as the flags are set to allow X presses, then the action listed in this will begin.")]
    [JsonPropertyName("branchYAtk_")]
    public int BranchYAtk { get; set; }

    [Description("When X is pressed within a specified window in the flags for the action/motions, it will go to the action listed.")]
    [JsonPropertyName("branchXAtk_Just_")]
    public int BranchXAtk_Just { get; set; }

    [Description("When Y is pressed within a specified window in the flags for the action/motions, it will go to the action listed.")]
    [JsonPropertyName("branchYAtk_Just_")]
    public int BranchYAtk_Just { get; set; }

    [Description("When X is held down before a specified time in the flags for the action, and continues to be held when the flag activates, this action will be called.")]
    [JsonPropertyName("branchXAtk_Hold_")]
    public int BranchXAtk_Hold { get; set; }

    [Description("When Y is held down before a specified time in the flags for the action, and continues to be held when the flag activates, this action will be called.")]
    [JsonPropertyName("branchYAtk_Hold_")]
    public int BranchYAtk_Hold { get; set; }

    [Description("Allows the action to automatically call another action after a hit is landed, depending on specific factors")]
    [JsonPropertyName("branchAtkHit_")]
    public int BranchAtkHit { get; set; }

    [Description("Affects the distance the action is set to be called at by AI")]
    [JsonPropertyName("dist_")]
    public float Dist { get; set; }

    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [Description("Controls how motions are handled when called by an action.")]
    [JsonPropertyName("controlTypeHash_")]
    public uint ControlTypeHash { get; set; }

    [JsonPropertyName("supportTypeHash_")]
    public uint SupportTypeHash { get; set; }

    [Description("A name assigned to the action by the devs, not referenced anywhere else.")]
    [JsonPropertyName("actionName_")]
    public string? ActionName { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId01_")]
    public string? SaveMotId01 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId02_")]
    public string? SaveMotId02 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId03_")]
    public string? SaveMotId03 { get; set; }

    [JsonPropertyName("saveMotId04_")]
    public string? SaveMotId04 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId05_")]
    public string? SaveMotId05 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId06_")]
    public string? SaveMotId06 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId07_")]
    public string? SaveMotId07 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId08_")]
    public string? SaveMotId08 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId09_")]
    public string? SaveMotId09 { get; set; }

    [Description("A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId10_")]
    public string? SaveMotId10 { get; set; }

    [Description("Added in Endless Ragnarok. A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId11_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string? SaveMotId11 { get; set; }

    [Description("Added in Endless Ragnarok. A motion associated with this action. Called depending on \"controlTypeHash_\", and affected by \"actionFreeWorkXX_\".")]
    [JsonPropertyName("saveMotId12_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string? SaveMotId12 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork01_")]
    public float ActionFreeWork01 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork02_")]
    public float ActionFreeWork02 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork03_")]
    public float ActionFreeWork03 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork04_")]
    public float ActionFreeWork04 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork05_")]
    public float ActionFreeWork05 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork06_")]
    public float ActionFreeWork06 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork07_")]
    public float ActionFreeWork07 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork08_")]
    public float ActionFreeWork08 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork09_")]
    public float ActionFreeWork09 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork10_")]
    public float ActionFreeWork10 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork11_")]
    public float ActionFreeWork11 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork12_")]
    public float ActionFreeWork12 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork13_")]
    public float ActionFreeWork13 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork14_")]
    public float ActionFreeWork14 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork15_")]
    public float ActionFreeWork15 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork16_")]
    public float ActionFreeWork16 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork17_")]
    public float ActionFreeWork17 { get; set; }

    [Description("Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork18_")]
    public float ActionFreeWork18 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork19_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork19 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork20_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork20 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork21_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork21 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork22_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork22 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork23_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork23 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork24_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork24 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork25_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork25 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork26_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork26 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork27_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork27 { get; set; }

    [Description("Added in Endless Ragnarok. Values associated with the action, such as for Zeta, when she does a Rhapsody parry, the angle of bounce and force behind the lift will be listed here.")]
    [JsonPropertyName("actionFreeWork28_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float ActionFreeWork28 { get; set; }

    [JsonPropertyName("freeWork01_")]
    public float FreeWork01 { get; set; }

    [JsonPropertyName("freeWork02_")]
    public float FreeWork02 { get; set; }

    [JsonPropertyName("freeWork03_")]
    public float FreeWork03 { get; set; }

    [JsonPropertyName("freeWork04_")]
    public float FreeWork04 { get; set; }

    [Description("Always 1 seemingly.")]
    [JsonPropertyName("freeWork05_")]
    public float FreeWork05 { get; set; }

    [Description("Always 1 seemingly.")]
    [JsonPropertyName("freeWork06_")]
    public float FreeWork06 { get; set; }

    [Description("""
        Can refer to the FSM associated with the action. 
        This is only used on some of the first characters designed, such as Captain, and is set within the executable. 
        Requires the correct flags during the action to call the FSM.
        """)]
    [JsonPropertyName("bulletType_")]
    public int BulletType { get; set; }

    [JsonPropertyName("bulletFreeWork01_")]
    public int BulletFreeWork01 { get; set; }

    [JsonPropertyName("bulletFreeWork02_")]
    public int BulletFreeWork02 { get; set; }

    [JsonPropertyName("bulletFreeWork03_")]
    public int BulletFreeWork03 { get; set; }

    [JsonPropertyName("bulletFreeWork04_")]
    public int BulletFreeWork04 { get; set; }

    [Description("""
        Utilizes a hash and 6 values in an array format to state the buffs that will be applied to the character or team members when this player calls this action, 
        so long as the required flag is in any of the motions tied to the action. The first value in the array states how many buffs the game will attempt to give.
        """)]
    [JsonPropertyName("supportEffectList_")]
    public BindingList<SupportEffect> SupportEffectList { get; set; } = []; // std::vector<ActionInfo::SupportEffect>

    [JsonPropertyName("uiIconCategory_")]
    public int UiIconCategory { get; set; }

    [Description("BitFlag that affects how this action is called by AI when the skill is available. Each has specific requirements to be active depending on conditions set in the executable.")]
    [JsonPropertyName("actionCategory_")]
    public ActionCategory ActionCategory { get; set; }

    [JsonPropertyName("isTriggerAttackHit_")]
    public bool IsTriggerAttackHit { get; set; }

    [JsonPropertyName("derivedId_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int DerivedId { get; set; }

    [Description("Unused after version 1.3 of the game. Utilizes \"damageLimitDataIndex_\" instead.")]
    [JsonPropertyName("damageLimitType_")]
    public int DamageLimitType { get; set; }

    [Description("Specifies the damage cap in the Parameter File's damage cap index that is associated with this action.")]
    [JsonPropertyName("damageLimitDataIndex_")]
    public int DamageLimitDataIndex { get; set; }

    [Description("""
        Associates the action with the id assigned (Ie. \"AB_PL0000_09\" would be assigned \"8\"), 
        possibly not needed, changing it still allowed the action to function as intended
        """)]
    [JsonPropertyName("relatedAbilityType_")]
    public int RelatedAbilityType { get; set; }

    [Description("Additional honors, possibly given on granting buffs to other players, not fully aware of how honors works")]
    [JsonPropertyName("indirectDamagePoint_")]
    public float IndirectDamagePoint { get; set; }

    [Description("Unknown. True for Vane's Bubble")]
    [JsonPropertyName("isIndirectDamageAddMulti_")]
    public bool IsIndirectDamageAddMulti { get; set; }

    [Description("""
        Requires more testing. 
        Disables players from casting a skill and having access to the skill follow-ups listed in BranchXAtk and BranchYAtk before the skill cooldown is used
        """)]
    [JsonPropertyName("isCheckComboCutAbility_")]
    public bool IsCheckComboCutAbility { get; set; }

    [JsonPropertyName("isNoClearPrecedingInput_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsNoClearPrecedingInput { get; set; }

    [JsonPropertyName("isChangeAttackInputPriority_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsChangeAttackInputPriority { get; set; }

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
    [Description("Bit0: Gap Closer (Not Used)")]
    GapCloser = 1u << 0,

    [Description("Bit1: Dodge/Parry (Not Used)")]
    DodgeParry = 1u << 1,

    [Description("Bit2: Buff - Active if within distance specified in \"dist_\". Low Priority.")]
    Buff = 1u << 2,

    [Description("Bit3: Debuff - Active if within distance specified in \"dist_\". Low Priority.")]
    Debuff = 1u << 3,

    [Description("Bit4: Team Heal - Active depending on teammate HP values. High Priority.")]
    TeamHeal = 1u << 4,

    [Description("Bit5: Damage - Active if within distance specified in \"dist_\". Low Priority.")]
    Damage = 1u << 5,

    [Description("Bit6: Unused")]
    StunMaybe = 1u << 6,

    [Description("Bit7: Ban Action (Crowd control like freeze) - Middle Priority.")]
    BanAction = 1u << 7,

    [Description("Bit8: Self Heal - Active depending on AI HP value. High Priority.")]
    SelfHeal = 1u << 8,

    [Description("Bit9: Cleanse - Active depending on if any character on the team has a debuff. High Priority.")]
    Cleanse = 1u << 9,

    [Description("Bit10: Revive - Active depending on if any character on the team is down. High Priority.")]
    Revive = 1u << 10,

    [Description("Bit11: Parry")]
    Parry = 1u << 11,

    Bit12 = 1u << 12,
    Bit13 = 1u << 13,
    Bit14 = 1u << 14,
    Bit15 = 1u << 15,
    Bit16 = 1u << 16,
    Bit17 = 1u << 17,
    Bit18 = 1u << 18,
    Bit19 = 1u << 19,
    Bit20 = 1u << 20,
    Bit21 = 1u << 21,
    Bit22 = 1u << 22,
    Bit23 = 1u << 23,
    Bit24 = 1u << 24,
    Bit25 = 1u << 25,
    Bit26 = 1u << 26,
    Bit27 = 1u << 27,
    Bit28 = 1u << 28,
    Bit29 = 1u << 29,
    Bit30 = 1u << 30,
    Bit31 = 1u << 31,
}

[Flags]
public enum StraddleFlagBit
{
    [Description("Bit0: Enables BranchXAtk/BranchYAtk. If not active in an action, follow-ups will be the neutral X and Y presses for the character.")]
    Bit0 = 1 << 0,

    [Description("Bit1: unknown. Seen on Skills.")]
    Bit1 = 1 << 1,

    [Description("Bit2: unknown. Seen on Charge Attacks, as well as Attacks that lead into charge attacks.")]
    Bit2 = 1 << 2,

    [Description("Bit3: Seen on Perfect Attacks. Not required for Perfect Attacks to function.")]
    Bit3 = 1 << 3,

    [Description("Bit4: Seen on Id's Combo Finisher Slam, Talviyo, Flashing Void, and Narmaya's Stance Swap Attacks")]
    Bit4 = 1 << 4,

    [Description("Bit5: Seen on Vaseraga's Air Normal Attacks and Cagliostro's Pain Train.")]
    Bit5 = 1 << 5,
}