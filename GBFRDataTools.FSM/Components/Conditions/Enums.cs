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
    Lesser = 0,
    LesserEqual = 1,
    Equal = 2,
    Greater = 3,
    GreaterEqual = 4,
}

public enum BlackBoardIntOperatorType
{
    Equal = 0,
    Lesser = 1,
    LesserEqual = 2,
    Greater = 3,
    GreaterEqual = 4,
}

public enum EmAILevelConditionOperatorType
{
    Lesser = 0,
    LesserEqual = 1,
    Equal = 2,
    GreaterEqual = 3,
    Greater = 4,
}

public enum EmClosestPlayerRangeConditionOperatorType
{
    Lesser = 0,
    LesserEqual = 1,
    Equal = 2,
    GreaterEqual = 3,
    Greater = 4,
}

public enum ShotUserCustomTypeConditionOperatorType
{
    Equal = 0,
    Lesser = 1,
    LesserEqual = 2,
    Greater = 3,
    GreaterEqual = 4,
}

public enum SoundMixBalanceCameraShakeConditionOperatorType
{
    Equal = 0,
    Lesser = 1,
    LesserEqual = 2,
    Greater = 3,
    GreaterEqual = 4,
}

public enum AIBattleSequenceConditionFlagType
{
    [Description("X and Y Attack Available (Flag0: Bit1)")]
    XY = 0,

    Type1 = 1,

    [Description("Y Attack Available (Flag0: Bit6)")]
    Y = 2,

    [Description("Follow-Up Window End (Flag0: Bit30)")]
    End = 3,

    [Description("Perfect Window Start (Flag?:Bit?)")]
    Perfect = 4,
}