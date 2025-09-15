using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[Description("""
    Creates an active hitbox for a projectile fsm.
    Only functions on FSMs that are given the "shot" classification. if used in an fsm that is classified as an areaattack, will not function
    """)]
public class ShotAttackAction : ShotHitBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotAttackAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0;

    [JsonPropertyName("target_")]
    public int Target { get; set; } = 0;

    [JsonPropertyName("globalType_")]
    public int GlobalType { get; set; } = 0;

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } = 0;

    [JsonPropertyName("hitFlag_")]
    public /*ulong*/ HitFlag HitFlag { get; set; } = 0;

    [JsonPropertyName("categoryFlag_")]
    public CategoryFlag CategoryFlag { get; set; } = 0;

    // data type says it's int, but pl1400_ab_step_shot_2_fsm_ingame uses float
    [JsonPropertyName("element_")]
    public Element Element { get; set; } = 0;

    [Obsolete("Not read by the game")]
    [JsonPropertyName("badStatus_")]
    public int BadStatus { get; set; }

    [Description("""
        Amount of the character's attack stat to apply to DMG calculations on a per hit basis. 
        Refer to enemy_status.tbl for enemy attack stats.
        """)]
    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } = 1.0f;

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } = 1.0f;

    [Description("""
        Amount of SBA gauge to gain for the attack on a per hit basis. 
        Affected by Uplift and in-game multipliers
        """)]
    [JsonPropertyName("spArtsRate_")]
    public float SpArtsRate { get; set; } = 1.0f;

    [Description("Amount of time, in seconds, for the game to create \"Hitstop\" when the attack lands.")]
    [JsonPropertyName("hitStopSecond_")]
    public float HitStopSecond { get; set; }

    [JsonPropertyName("hitVibrationType_")]
    public int HitVibrationType { get; set; }

    [Description("""
        Amount of time, in seconds, that a hitbox will remain active for. 
        Not sure if an FSM can call multiple hitboxes at the same time, or if the most recent will override.
        """)]
    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; } = 0;

    [Description("""
        Amount of time, in seconds, that a hitbox will take to hit again. 
        Subject to MultiHitLimit for maximum number of hits. 
        """)]
    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } = 0.0f;

    [JsonPropertyName("knockBackRate_")]
    public float KnockBackRate { get; set; } = 1.0f;

    [JsonPropertyName("damageMovementRate_")]
    public float DamageMovementRate { get; set; } = 1.0f;

    [JsonPropertyName("damageMovementRateY_")]
    public float DamageMovementRateY { get; set; } = 1.0f;

    [Description("""
        Only allows the active hitbox to hit once. 
        This counts per FSM, so any previous hits called in any specific FSM will count towards this total. 
        Certain hitboxes with certain flags may still create "hits", but do not count to this total.
        """)]
    [JsonPropertyName("isHitOnce_")]
    public bool IsHitOnce { get; set; } = true;

    [Description("""
        Requires Testing, asummed to move the FSM origin to the location where this active hitbox overlaps with a targettable hitbox. 
        Not sure how it handles hitting multiple enemies at the same time.
        """)]
    [JsonPropertyName("isMoveToHitPos_")]
    public bool IsMoveToHitPos { get; set; }

    [JsonPropertyName("isSetAttackerPos_")]
    public bool IsSetAttackerPos { get; set; } = false;

    [JsonPropertyName("isSetAttackerHitList_")]
    public bool IsSetAttackerHitList { get; set; }

    [Description("Whether to clear all hit count calculations. If false, any hits called by this action will count towards the first called \"MultiHitLimit\" with a valid number.")]
    [JsonPropertyName("isClearHitList_")]
    public bool IsClearHitList { get; set; } = true;

    [Description("Creates an FSM-wide hit count maximum. Any actions with \"IsClearHitList\" set to true will void previous calls. Actions set to \"IsHitOnce\" do not count to the total.")]
    [JsonPropertyName("multiHitLimit_")]
    public int MultiHitLimit { get; set; } = 0;

    [JsonPropertyName("isSwept_")]
    public bool IsSwept { get; set; } = false;

    [Description("Debuffs to be applied by this hitbox on a per hit basis.")]
    [JsonPropertyName("debuffList_")]
    public BindingList<DebuffData> DebuffList { get; set; } = [];

    [JsonPropertyName("attackClearTime_")]
    public float AttackClearTime { get; set; } = 0.0f;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkRateSubDist_")]
    public int AtkRateSubDist { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkRateMaxSubDist_")]
    public int AtkRateMaxSubDist { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("atkSubRateClamp_")]
    public int AtkSubRateClamp { get; set; }

    [Description("""
        NEEDS TESTING 
        Start of the Appropriate Attack Range, in which a normal AttackRate, Specified above, is applied instead of the alternate, specified in NotAppropriDistAtkRate
        """)]
    [JsonPropertyName("appropriStartDist")]
    public float AppropriStartDist { get; set; } = -1.0f;

    [Description("""
        NEEDS TESTING 
        Distance at which, once passed, an alternate AttackRate is applied instead
        """)]
    [JsonPropertyName("appropriEndDist")]
    public float AppropriEndDist { get; set; } = 0.0f;

    [Description("""
        NEEDS TESTING 
        Amount of attack to deal instead, if the targettable hitbox is more than the distance specified in "AppropriEndDistance" away from player(?) fsm origin(?), maybe requires "IsTakeOverAppropriDist" to be true?
        """)]
    [JsonPropertyName("notAppropriDistAtkRate_")]
    public float NotAppropriDistAtkRate { get; set; } = 0.0f;

    [JsonPropertyName("isTakeOverAppropriDist_")]
    public bool IsTakeOverAppropriDist { get; set; } = false;

    [JsonPropertyName("isAlreadyHitClearEachEntity_")]
    public bool IsAlreadyHitClearEachEntity { get; set; } = false;

    [JsonPropertyName("isHitOnlyHormingTarget_")]
    public bool IsHitOnlyHormingTarget { get; set; } = false;

    [Obsolete("Not read by the game, NEEDS TESTING. Amount of time to dalay before activating the hitbox?")]
    [JsonPropertyName("setAttackDelayTime_")]
    public int SetAttackDelayTime { get; set; }

    public ShotAttackAction()
    {
        Offset = Vector4.UnitW;
        Size = Vector4.One;
        DegreeX = 0f;
        DegreeY = 0f;
        DegreeZ = 0f;
        Shape = 0;
    }
}

public enum Element
{
    Neutral = 0,
    Fire = 1,
    Water = 2,
    Earth = 3,
    Wind = 4,
    Light = 5,
    Dark = 6,
}

[Flags]
public enum HitFlag : long
{
    Bit0 = 1 << 0, 
    Bit1 = 1 << 1, 
    Bit2 = 1 << 2, // Seen in invisible hits for player fsms - nothing visible during test
    Bit3 = 1 << 3, 
    Bit4 = 1 << 4, // Eugen's Ranged normal - nothing visible during test
    Bit5 = 1 << 5, // Removes hitmarker (adds a stagger on first activation/no debuff when combined with certain other hitflags)
    Bit6 = 1 << 6, // Required for an SBA to perform its hits
    Bit7 = 1 << 7, // Allows the hitbox to ONLY hit enemies that are Link Attack-able. Counts as a link Attack. Disables Supplementary DMG.
    Bit8 = 1 << 8, 
    Bit9 = 1 << 9, // Allows an SBA hit to be tracked for the final TOTAL DAMAGE number that pops up after a chain or single SBA
    Bit10 = 1 << 10, 
    Bit11 = 1 << 11, 
    Bit12 = 1 << 12, 
    Bit13 = 1 << 13, // Disables SBA gain, and stops stun bar build up of enemy after hit, causes SBA damage reaction from opponents
    Bit14 = 1 << 14, // Disables Stun bar build up of enemy after hit, Causes SBA damage reaction from opponents
    Bit15 = 1 << 15, 
    Bit16 = 1 << 16, // seen in Eugen's Ranged Normal, seen in Sandy's SBA, nothing visible during test
    Bit17 = 1 << 17, 
    Bit18 = 1 << 18, // Disables a player from blocking the attack with guard. Also disables non-BT damage reduction effects from enemies, like Id's Guard move
    Bit19 = 1 << 19, // Attacks through invulnerability (MI included, does not take MI procs however)
    Bit20 = 1 << 20, // Seen in invisible hits for player fsms, also eugen's ranged normal, eugen link attack
    Bit21 = 1 << 21, // ?
    Bit22 = 1 << 22, 
    Bit23 = 1 << 23, 
    Bit24 = 1 << 24, 
    Bit25 = 1 << 25, // Seen in invisible hits for player fsms, also eugen's ranged normal, eugen link attack, Eugen SBA startup, Sandy's SBA. Not visible during testing 
    Bit26 = 1 << 26, // Removes the damage number from the hitbox. Damage, Stun and SBA gain function as normal. Disables interaction with Eugen's Grenades for Eugen.
    Bit27 = 1 << 27, // Seen in Captain's ODS
    Bit28 = 1 << 28, 
    Bit29 = 1 << 29, 
    Bit30 = 1 << 30, // Seen in Io's SBA
    Bit31 = 1 << 31, 
    Bit32 = 1 << 32, 
    Bit33 = 1 << 33, // Disables a player from perfect dodging the attack
    Bit34 = 1 << 34, 
    Bit35 = 1 << 35, 
    Bit36 = 1 << 36,
    Bit37 = 1 << 37, 
    Bit38 = 1 << 38, 
    Bit39 = 1 << 39, 
    Bit40 = 1 << 40, 
    Bit41 = 1 << 41, 
    Bit42 = 1 << 42, // Makes AI jump over the hitbox if possible
    Bit43 = 1 << 43, 
    Bit44 = 1 << 44, // Caps damage of hit to 0. Stun and SBA gain function normally. Disables Critting.
    Bit45 = 1 << 45, // ?
    Bit46 = 1 << 46, 
    Bit47 = 1 << 47, // Stops AI from attempting to dodge it
    Bit48 = 1 << 48, 
    Bit49 = 1 << 49, 
    Bit50 = 1 << 50, 
    Bit51 = 1 << 51, 
    Bit52 = 1 << 52, 
    Bit53 = 1 << 53, 
    Bit54 = 1 << 54, 
    Bit55 = 1 << 55, 
    Bit56 = 1 << 56, 
    Bit57 = 1 << 57, 
    Bit58 = 1 << 58, 
    Bit59 = 1 << 59, 
    Bit60 = 1 << 60, 
    Bit61 = 1 << 61, 
    Bit62 = 1 << 62, 
    Bit63 = 1 << 63, 
    Bit64 = 1 << 64, 
}
public enum AttackType
{
    [Description("Normal Hitboxes (?)")]
    NormalHitbox,

    Unk2,

    Unk3,

    [Description("Pull? Makes BreakRate pull rate instead")]
    Pull,
}

[Flags]
public enum CategoryFlag
{
    [Description("Normal Attack - (not all normal attacks have this bitflag)")]
    NormalAttack = 1 << 0,

    [Description("Charged Attack")]
    ChargedAttack = 1 << 1,

    Bit2 = 1 << 2,

    [Description("Ranged Attack")]
    RangedAttack = 1 << 3,

    Bit4 = 1 << 4,

    [Description("Combo Finisher")]
    ComboFinisher = 1 << 5,

    [Description("Throw")]
    Throw = 1 << 6,

    Unk7 = 1 << 7,

    [Description("Perfect")]
    Perfect = 1 << 8,

    Bit9 = 1 << 9,
    Bit10 = 1 << 10,
    Bit11 = 1 << 11,
    Bit12 = 1 << 12,
    Bit13 = 1 << 13,
    Bit14 = 1 << 14,
    Bit15 = 1 << 15,

    [Description("Skill")]
    Skill = 1 << 16,

    [Description("Link Attack")]
    LinkAttack = 1 << 17,

    [Description("Special Arts (SBA)")]
    SpArts = 1 << 18,
}

public enum Reaction
{
    [Description("Standard minor knockback")]
    MinorKnockback = 0,

    [Description("Launch backwards and upwards")]
    Throw = 1,

    [Description("Launch backwards really far and upwards")]
    ThrowFar = 2,

    [Description("Launch directly vertical")]
    LaunchVertical = 3,
    Unk4 = 4,
    Unk5 = 5,
    Unk6 = 6,
    Unk7 = 7,
    Unk8 = 8,
    Unk9 = 9,
    Unk10 = 10,
    Unk11 = 11,
    Unk12 = 12,
    Unk13 = 13,

    [Description("None")]
    None = 14,

}