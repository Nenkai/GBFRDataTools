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