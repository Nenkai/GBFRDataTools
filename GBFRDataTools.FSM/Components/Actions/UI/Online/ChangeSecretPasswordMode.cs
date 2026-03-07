using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Online;

public class ChangeSecretPasswordMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeSecretPasswordMode);

    [JsonPropertyName("mode_")]
    public EnumString<ChangeSecretPasswordModeEnum> Mode { get; set; } // Offset 0x30
}

public enum ChangeSecretPasswordModeEnum
{
    Reset = 0,
    Change = 1,
}