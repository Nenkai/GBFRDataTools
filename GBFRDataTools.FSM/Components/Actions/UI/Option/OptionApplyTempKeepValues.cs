using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Option;

public class OptionApplyTempKeepValues : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OptionApplyTempKeepValues);

    [JsonPropertyName("timing_")]
    public EnumString<OptionApplyTempKeepValuesTiming> Timing { get; set; }

    [JsonPropertyName("itemID_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public string ItemId { get; set; }
}

public enum OptionApplyTempKeepValuesTiming
{
    // オプション閉じた時 = 0
    WhenOptionsAreClosed = 0,
}