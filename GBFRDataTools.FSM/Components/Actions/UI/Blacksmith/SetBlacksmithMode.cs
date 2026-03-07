using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Blacksmith;

public class SetBlacksmithMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBlacksmithMode);

    [JsonPropertyName("mode_")]
    public EnumString<BlacksmithModeEnum> Mode { get; set; } // Offset 0x30

    public SetBlacksmithMode()
    {
    }
}

public enum BlacksmithModeEnum
{
    Upgrade = 0,
    Craft = 1,
    Pendulum = 2,
    Type3 = 3,
    Geen = 4,
    LimitBrake = 5,
    Type6 = 6,
    Type7 = 7,
    Type8 = 8,
    WeaponAwake = 9,
    WeaponAwakeEnhance = 10,
}
