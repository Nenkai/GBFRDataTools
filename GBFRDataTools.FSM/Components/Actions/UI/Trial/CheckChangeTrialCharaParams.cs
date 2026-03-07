using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Trial;

public class CheckChangeTrialCharaParams : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckChangeTrialCharaParams);

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0x30

    public CheckChangeTrialCharaParams()
    {
    }
}
