using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

// This should be hopefully correct.. Baffling it's not one single enum
public enum BlackBoardFloatOperatorType
{
    [Description("<")]
    Lesser = 0,

    [Description("<=")]
    LesserEqual = 1,

    [Description("==")]
    Equal = 2,

    [Description(">")]
    Greater = 3,

    [Description(">=")]
    GreaterEqual = 4,
}

public enum BlackBoardIntOperatorType
{
    [Description("==")]
    Equal = 0,

    [Description("<")]
    Lesser = 1,

    [Description("<=")]
    LesserEqual = 2,

    [Description(">")]
    Greater = 3,

    [Description(">=")]
    GreaterEqual = 4,
}

public enum EmAILevelConditionOperatorType
{
    [Description("<")]
    Lesser = 0,

    [Description("<=")]
    LesserEqual = 1,

    [Description("==")]
    Equal = 2,

    [Description(">=")]
    GreaterEqual = 3,

    [Description(">")]
    Greater = 4,
}

public enum EmClosestPlayerRangeConditionOperatorType
{
    [Description("<")]
    Lesser = 0,

    [Description("<=")]
    LesserEqual = 1,

    [Description("==")]
    Equal = 2,

    [Description(">=")]
    GreaterEqual = 3,

    [Description(">")]
    Greater = 4,
}

public enum ShotUserCustomTypeConditionOperatorType
{
    [Description("==")]
    Equal = 0,

    [Description("<")]
    Lesser = 1,

    [Description("<=")]
    LesserEqual = 2,

    [Description(">")]
    Greater = 3,

    [Description(">=")]
    GreaterEqual = 4,
}

public enum SoundMixBalanceCameraShakeConditionOperatorType
{
    [Description("==")]
    Equal = 0,

    [Description("<")]
    Lesser = 1,

    [Description("<=")]
    LesserEqual = 2,

    [Description(">")]
    Greater = 3,

    [Description(">=")]
    GreaterEqual = 4,
}

public enum AIBattleSequenceConditionFlagType
{
    [Description("X and Y Attack Available (Flag0: Bit1)")]
    XY = 0,

    [Description("X and Y Attack Available (Flag0: Bit24)")]
    Type1 = 1,

    [Description("Y Attack Available (Flag0: Bit6)")]
    Y = 2,

    [Description("Character can walk/End of action (Flag0: Bit0)")]
    EndOfAction = 3,

    [Description("Perfect Window Start (Flag1:Bit18)")]
    Perfect = 4,

    [Description("? (Flag0:Bit13)")]
    Type5 = 5,

    [Description("? (Flag0:Bit2)")]
    Type6 = 6,

    [Description("? (Flag1:Bit8)")]
    Type7 = 7,

    [Description("? (Flag1:Bit9)")]
    Type8 = 8,

    [Description("? (Flag1:Bit10)")]
    Type9 = 9,

    [Description("? (Flag1:Bit11)")]
    Type10 = 10,

    [Description("? (Flag1:Bit0)")]
    Type11 = 11,

    [Description("? (Flag1:Bit12)")]
    Type12 = 12,
}