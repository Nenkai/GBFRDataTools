using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SendSignal : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SendSignal);

    [JsonPropertyName("signalField_")]
    [Description($$"""
        Main signal. For more than one signal, refer to `{{nameof(IsMultiSelect)}}`
        [0] = signal type? idk
        [1] = 0 = placement object? otherwise cutscene type
        [2] = If
              - Placement Object => Uuid of placement/layout object
              - Cutscene type => Cutscene id
        [3] = If
              - PlacementObject: status option of said object
        """)]
    [Editable(false)]
    public BindingList<ulong> SignalField { get; set; } = [.. Enumerable.Repeat<ulong>(0, 4)]; // cy::PlacementInfo::Values

    [JsonPropertyName("skipAtSectionJump_")]
    [Description($"Only if {nameof(IsMultiSelect)} = false.")]
    public bool SkipAtSectionJump { get; set; } = false;

    [JsonPropertyName("isMultiSelect_")]
    [Description($"If true, select multiple signals (provided by {nameof(IsMultiSelect)})")]
    public bool IsMultiSelect { get; set; } = false;

    [JsonPropertyName("signalInfos_")]
    [Description($"Up to 32. `{nameof(IsMultiSelect)}` must be true.")]
    public Controllers<SignalInfos> SignalInfos { get; set; } = [];
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class SignalInfos /* BT::SendSignal::SignalInfos */
{
    [JsonPropertyName("signal_")]
    public Signal Signal { get; set; } = new();

    [JsonPropertyName("skipAtSectionJump_")]
    public bool SkipAtSectionJump { get; set; } = false;
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Signal
{
    [JsonPropertyName("x_")]
    public ulong X { get; set; }

    [JsonPropertyName("y_")]
    public ulong Y { get; set; }

    [JsonPropertyName("z_")]
    public ulong Z { get; set; }

    [JsonPropertyName("w_")]
    public ulong W { get; set; }
}
