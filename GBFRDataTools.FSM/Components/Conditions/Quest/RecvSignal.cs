using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class RecvSignal : QuestConditionComponent
{
    [JsonPropertyName("signalField_")]
    public /*cy::PlacementInfo::Values*/ ElementArray<ulong> SignalField { get; set; }

    [JsonPropertyName("resetOnStart_")]
    public bool ResetOnStart { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- Signal Field: [{string.Join(", ", SignalField)}]\n";
        str += $"- ResetOnStart: {ResetOnStart}";

        return str;
    }
}

public class PlacementInfoValues
{

}
