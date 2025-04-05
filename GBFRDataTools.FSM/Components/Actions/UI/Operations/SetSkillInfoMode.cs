using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Operations;

public class SetSkillInfoMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetSkillInfoMode);

    [JsonPropertyName("modeEnum_")]
    public EnumString ModeEnum { get; set; } = new();
}
