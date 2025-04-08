using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Pause;

public class SetPauseMenuMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPauseMenuMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString ModeEnum { get; set; } = new();

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false;
}
