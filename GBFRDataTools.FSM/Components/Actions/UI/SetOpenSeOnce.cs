using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetOpenSeOnce : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOpenSeOnce);

    [JsonPropertyName("controllerName_")]
    public string ControllerName { get; set; } // Offset 0x30

    [JsonPropertyName("openSe_")]
    public EnumString<SetOpenSeOnceEnum> OpenSe { get; set; } // Offset 0x80

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0xB0
}

public enum SetOpenSeOnceEnum
{
    None = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
    Type5 = 5,
    Type6 = 6,
    Error = 7,
    Type8 = 8,
    Type9 = 9,
    Type10 = 10,
    Type11 = 11,
    Open = 12,
}