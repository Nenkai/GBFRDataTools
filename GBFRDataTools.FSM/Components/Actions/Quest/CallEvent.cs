using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallEvent : QuestActionComponent
{
    [JsonPropertyName("signalField_")]
    public BindingList<int> SignalField { get; set; }

    [JsonPropertyName("useOffset_")]
    public bool UseOffset { get; set; }

    [JsonPropertyName("offsetUniqueIdHash_")]
    public ulong OffsetUniqueIdHash { get; set; }

    [JsonPropertyName("isFadeInEventAfter_")]
    public bool IsFadeInEventAfter { get; set; }

    [JsonPropertyName("forceFadeTime_")]
    public float ForceFadeTime { get; set; }

    [JsonPropertyName("forceEndFadeTime_")]
    public float ForceEndFadeTime { get; set; }

    [JsonPropertyName("useMovePos_")]
    public bool UseMovePos { get; set; }

    [JsonPropertyName("movePlayerPosHash_")]
    public BindingList<ulong> MovePlayerPosHash { get; set; }

    [JsonPropertyName("moveGuestPosHash_")]
    public BindingList<ulong> MoveGuestPosHash { get; set; }

    [JsonPropertyName("suspensionActEventAfter_")]
    public bool SuspensionActEventAfter { get; set; }
}
