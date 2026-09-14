using GBFRDataTools.FSM.Components.Actions.UI.Fade;

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

public class CallTimelineSystemSe : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallTimelineSystemSe);

    [JsonPropertyName("pattern_")]
    public uint Pattern { get; set; } = 3;

    [JsonPropertyName("signalField_")]
    [Editable(false)]
    public BindingList<ulong> SignalField { get; set; } = [.. Enumerable.Repeat<ulong>(0, 4)]; // cy::PlacementInfo::Values

    public override string? GetCaption()
    {
        return $"Pattern: {Pattern}";
    }
}
