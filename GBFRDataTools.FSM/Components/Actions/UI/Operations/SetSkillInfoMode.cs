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
    public EnumString<SetSkillInfoModeMode> ModeEnum { get; set; } = new();
}

public enum SetSkillInfoModeMode
{
    // 通常 = 0,
    // 全選択 = 1,
    Usually = 0,
    SelectAll = 1,
}