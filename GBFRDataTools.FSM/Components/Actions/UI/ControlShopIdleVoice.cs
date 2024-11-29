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

public class ControlShopIdleVoice : ActionComponent
{
    [JsonPropertyName("controlType_")]
    public EnumString ControlType { get; set; } = new();
}
