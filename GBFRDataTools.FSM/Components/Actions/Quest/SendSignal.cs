using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    [Description("""
        [0] = signal type? idk
        [1] = 0 = placement object? otherwise cutscene type
        [2] = If
              - Placement Object => Uuid of placement/layout object
              - Cutscene type => Cutscene id
        [3] = If
              - PlacementObject: status option of said object
        """)]
    [JsonPropertyName("signalField_")]
    public /*cy::PlacementInfo::Values*/ BindingList<ulong> SignalField { get; set; } = [];

    [JsonPropertyName("skipAtSectionJump_")]
    public bool SkipAtSectionJump { get; set; } = false;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isMultiSelect_")]
    public bool IsMultiSelect { get; set; } = false;
     
    [Obsolete("Not used by the game")]
    [JsonPropertyName("signalInfos_")]
    public object SignalInfos { get; set; } // Array?
}

public class PlacementInfoValues
{

}
