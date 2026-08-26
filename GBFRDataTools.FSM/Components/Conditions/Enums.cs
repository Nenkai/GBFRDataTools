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

    [Description("Skill Input Available (Flag0:Bit13)")]
    SkillInput = 5,

    [Description("Dodge Input Available (Flag0:Bit2)")]
    DodgeInput = 6,

    [Description("Unconditional Character Resource Gained (Io Mystic Vortex - Flag1:Bit8)")]
    CharacterResourceGained = 7,

    [Description("? (Flag1:Bit9)")]
    Type8 = 8,

    [Description("Weapon Appearance Changed? (Flag1:Bit10)")]
    WeaponAppearanceChanged = 9,

    [Description("? (Flag1:Bit11)")]
    Type10 = 10,

    [Description("Multi-use, Unknown (Flag1:Bit0)")]
    Type11 = 11,

    [Description("? (Flag1:Bit12)")]
    Type12 = 12,
}