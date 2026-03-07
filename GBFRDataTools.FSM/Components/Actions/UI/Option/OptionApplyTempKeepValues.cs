using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Option;

public class OptionApplyTempKeepValues : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OptionApplyTempKeepValues);

    [JsonPropertyName("timing_")]
    public EnumString<OptionApplyTempKeepValuesTiming> Timing { get; set; } // Offset 0x30

    public OptionApplyTempKeepValues()
    {
    }
}

public enum OptionApplyTempKeepValuesTiming
{
    // オプション閉じた時 = 0
    WhenOptionsAreClosed = 0,
}