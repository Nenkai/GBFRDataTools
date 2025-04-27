using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class ControlTrialOption : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlTrialOption);

    [JsonPropertyName("mode_")]
    public EnumString<ControlTrialOptionMode> Mode { get; set; } // Offset 0x30

    public ControlTrialOption()
    {
    }
}

public enum ControlTrialOptionMode
{
    UnknownType0 = 0,
    ClearPendingOptions = 1,
    ReflectPendingOptions = 2,
}