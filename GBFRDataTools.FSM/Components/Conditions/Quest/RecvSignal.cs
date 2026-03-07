using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class RecvSignal : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RecvSignal);

    [JsonPropertyName("signalField_")]
    public /*cy::PlacementInfo::Values*/ BindingList<ulong> SignalField { get; set; } = []; // cy::PlacementInfo::Values - std::vector<unisnged __int64>

    [JsonPropertyName("resetOnStart_")]
    public bool ResetOnStart { get; set; } = false;
}

public class PlacementInfoValues
{

}
