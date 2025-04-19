using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Option;

public class OptionApply : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OptionApply);

    [JsonPropertyName("timing_")]
    public EnumString<OptionApplyTiming> Timing { get; set; } = new();
}

public enum OptionApplyTiming
{
    // Empty string
    Default = 0,
}