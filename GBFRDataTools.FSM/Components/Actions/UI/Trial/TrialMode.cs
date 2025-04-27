using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.Trial;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class TrialMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TrialMode);

    [JsonPropertyName("mode_")]
    public TrialModeBranchState Mode { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("mode_str_")]
    [Description("Name of mode enum value")]
    public string Mode_str { get; set; } // Offset 0x38

    public TrialMode()
    {
    }
}