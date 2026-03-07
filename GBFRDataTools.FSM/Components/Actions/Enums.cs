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