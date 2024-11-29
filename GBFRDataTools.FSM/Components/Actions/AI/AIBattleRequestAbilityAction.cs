using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleRequestAbilityAction : ActionComponent
{
    [JsonPropertyName("abilityFlagBit_")] // Checked against action -> actionCategory_?
    public AbilityActionFlagBit AbilityFlagBit { get; set; } = 0;
}

public enum AbilityActionFlagBit : uint
{
    Bit0 = 0,
    Bit1 = 1,
    Bit2 = 2,
    Bit3 = 3,
    Bit4 = 4,
    Bit5 = 5,
    Bit6 = 6,
    Bit7 = 7,
    Bit8 = 8,
    Bit9 = 9,
    Bit10 = 10,
    Bit11 = 11,
    Bit12 = 12,
    Bit13 = 13,
    Bit14 = 14,
    Bit15 = 15,
    Bit16 = 16,
    Bit17 = 17,
    Bit18 = 18,
    Bit19 = 19,
    Bit20 = 20,
    Bit21 = 21,
    Bit22 = 22,
    Bit23 = 23,
    Bit24 = 24,
    Bit25 = 25,
    Bit26 = 26,
    Bit27 = 27,
    Bit28 = 28,
    Bit29 = 29,
    Bit30 = 30,
    Bit31 = 31,
    Bit32 = 32,

}
