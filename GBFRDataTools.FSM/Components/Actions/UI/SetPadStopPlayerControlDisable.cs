using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPadStopPlayerControlDisable : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPadStopPlayerControlDisable);

    [JsonPropertyName("disable_")]
    public bool Disable { get; set; } = false; // Offset 0x30

    public SetPadStopPlayerControlDisable()
    {
    }
}
