using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPauseMenuMode : ActionComponent
{
    [JsonPropertyName("modeEnum_")]
    public EnumString ModeEnum { get; set; }

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; }
}
