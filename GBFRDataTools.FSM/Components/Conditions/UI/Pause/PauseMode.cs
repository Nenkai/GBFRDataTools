using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Pause;

public class PauseMode : ConditionComponent
{
    public override string ComponentName => nameof(PauseMode);

    [JsonPropertyName("mode_")]
    public EnumString Mode { get; set; } // Offset 0x38
}
