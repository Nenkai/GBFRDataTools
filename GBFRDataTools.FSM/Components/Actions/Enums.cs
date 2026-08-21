using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions;

public enum SoftCallType
{
    [Description("Unknown Type 0")]
    Type0 = 0,

    [Description("Unknown Type 1")]
    Type1 = 1,

    [Description("Unknown Type 2")]
    Type2 = 2,

    [Description("Unknown Type 3")]
    Type3 = 3,

    [Description("Unknown Type 4")]
    Type4 = 4,
}

public enum BlackBoardCalcType
{
    Plus = 0,
    Minus = 1,
    Multiply = 2,
    Divide = 3,
    Modulo = 4,
}

public enum ShapeType
{
    [Description("None")]
    None = 0,

    // AttackSignFan
    [Description("Fan / 2D Cone")]
    Fan = 1,

    // AttackSignRect
    [Description("Rectangle")]
    Rect = 2,

    // AttackSignCircle
    [Description("Circle")]
    Circle = 3,

    // AttackSignRing
    [Description("Ring")]
    Ring = 4,

    // AttackSignParabola
    [Description("Parabola")]
    Parabola = 5,

    // AttackSignColorMaskCircle?
    [Description("ColorMaskCircle (?) (Shape 6)")]
    Shape6 = 6,

    // AttackSignLine
    [Description("Line")]
    Line = 7,
}

public enum ModeType
{
    Type0 = 0,
    Type1 = 1,
}

public enum ShotType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
    Type5 = 5,
    Type6 = 6,
    Type7 = 7,
    Type8 = 8,
    Type9 = 9,
    Type10 = 10,
    Type11 = 11,
    Type12 = 12,
    Type13 = 13,
    Type14 = 14,
    Type15 = 15,
    Type16 = 16,
    Type17 = 17,
    Type18 = 18,
    Type19 = 19,
    Type20 = 20,
    Type21 = 21,
}

public enum EmBreakDamageActionType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
}

public enum EmDamageRotActionUpdateType
{
    Type0 = 0,
    Type1 = 1,
}

public enum AIBattleAttackActionAttackType
{
    [Description("X Attack")]
    X = 0,

    [Description("Y Attack")]
    Y = 1,

    [Description("Unknown Type 2")]
    AttackType2 = 2,
}

public enum DebuffCategory
{
    Debuff = 0,
    DamageOverTime = 1,
}

public enum Debuff
{
    ATK_DOWN = 1, // 2
    DEF_DOWN = 2, // 3
    UNK_3 = 3, // -1
    UNK_4 = 4, // -1
    MAX_HP_DOWN = 5, // 5,
    STACKABLE_ATK_DOWN = 6, // 67
    STACKABLE_DEF_DOWN = 7, // 59
    FLAME_WOLF = 8, // 137
}

public enum DebuffStatus
{
    BURN = 1, // 1001
    DIZZY = 2, // 1003
    HELD_UNDER = 3, // = 1008
    FROSTBITE = 4, // = 1005
    STONE = 5, // 1006
    DEBUFF_1009 = 6, // = 1009
    DEBUFF_1010 = 7, // = 1010
    PARALYSIS = 8, // = 1007
    POISON = 9, // = 1000
    SLOW = 10, // = 1002
    FROZEN = 11, // = 1004
    DARKNESS = 12, // = 1011
    BIND = 13, // = 1012
    DEBUFF_1013 = 14, // = 1013
    HOSTILITYUP = 15, // = 1014
    BOUND = 16, // = 1015
    SKILL_SEALED = 17, // = 1016
    SBA_SEALED = 18, // = 1017
    BLIGHT = 19, // = 1018
    PETRIFY = 20, // = 1019
    ARVESS = 21, // = 1020
    WEAK = 22, // = 1021
    DEBUFF_1022 = 23, // = 1022
}

public enum PrepareWeaponStatus
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
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
public enum HitFlag : ulong
{
    Bit0 = 1ul << 0,
    Bit1 = 1ul << 1,
    Bit2 = 1ul << 2, // Seen in invisible hits for player fsms - nothing visible during test
    Bit3 = 1ul << 3,
    Bit4 = 1ul << 4, // Eugen's Ranged normal - nothing visible during test
    Bit5 = 1ul << 5, // Removes hitmarker (adds a stagger on first activation/no debuff when combined with certain other hitflags)
    Bit6 = 1ul << 6, // Required for an SBA to perform its hits
    Bit7 = 1ul << 7, // Allows the hitbox to ONLY hit enemies that are Link Attack-able. Counts as a link Attack. Disables Supplementary DMG.
    Bit8 = 1ul << 8,
    Bit9 = 1ul << 9, // Allows an SBA hit to be tracked for the final TOTAL DAMAGE number that pops up after a chain or single SBA
    Bit10 = 1ul << 10,
    Bit11 = 1ul << 11,
    Bit12 = 1ul << 12,
    Bit13 = 1ul << 13, // Disables SBA gain, and stops stun bar build up of enemy after hit, causes SBA damage reaction from opponents
    Bit14 = 1ul << 14, // Disables Stun bar build up of enemy after hit, Causes SBA damage reaction from opponents
    Bit15 = 1ul << 15,
    Bit16 = 1ul << 16, // seen in Eugen's Ranged Normal, seen in Sandy's SBA, nothing visible during test
    Bit17 = 1ul << 17,
    Bit18 = 1ul << 18, // Disables a player from blocking the attack with guard. Also disables non-BT damage reduction effects from enemies, like Id's Guard move
    Bit19 = 1ul << 19, // Attacks through invulnerability (MI included, does not take MI procs however)
    Bit20 = 1ul << 20, // Seen in invisible hits for player fsms, also eugen's ranged normal, eugen link attack
    Bit21 = 1ul << 21, // ?
    Bit22 = 1ul << 22,
    Bit23 = 1ul << 23,
    Bit24 = 1ul << 24,
    Bit25 = 1ul << 25, // Seen in invisible hits for player fsms, also eugen's ranged normal, eugen link attack, Eugen SBA startup, Sandy's SBA. Not visible during testing 
    Bit26 = 1ul << 26, // Removes the damage number from the hitbox. Damage, Stun and SBA gain function as normal. Disables interaction with Eugen's Grenades for Eugen.
    Bit27 = 1ul << 27, // Seen in Captain's ODS
    Bit28 = 1ul << 28,
    Bit29 = 1ul << 29,
    Bit30 = 1ul << 30, // Seen in Io's SBA
    Bit31 = 1ul << 31,
    Bit32 = 1ul << 32,
    Bit33 = 1ul << 33, // Disables a player from perfect dodging the attack
    Bit34 = 1ul << 34,
    Bit35 = 1ul << 35,
    Bit36 = 1ul << 36,
    Bit37 = 1ul << 37,
    Bit38 = 1ul << 38,
    Bit39 = 1ul << 39,
    Bit40 = 1ul << 40,
    Bit41 = 1ul << 41,
    Bit42 = 1ul << 42, // Makes AI jump over the hitbox if possible
    Bit43 = 1ul << 43,
    Bit44 = 1ul << 44, // Caps damage of hit to 0. Stun and SBA gain function normally. Disables Critting.
    Bit45 = 1ul << 45, // ?
    Bit46 = 1ul << 46,
    Bit47 = 1ul << 47, // Stops AI from attempting to dodge it
    Bit48 = 1ul << 48,
    Bit49 = 1ul << 49,
    Bit50 = 1ul << 50,
    Bit51 = 1ul << 51,
    Bit52 = 1ul << 52,
    Bit53 = 1ul << 53,
    Bit54 = 1ul << 54,
    Bit55 = 1ul << 55,
    Bit56 = 1ul << 56,
    Bit57 = 1ul << 57,
    Bit58 = 1ul << 58,
    Bit59 = 1ul << 59,
    Bit60 = 1ul << 60,
    Bit61 = 1ul << 61,
    Bit62 = 1ul << 62,
    Bit63 = 1ul << 63,
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