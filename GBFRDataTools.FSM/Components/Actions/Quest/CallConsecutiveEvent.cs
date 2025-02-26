using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallConsecutiveEvent : QuestActionComponent
{
    [JsonPropertyName("eventControllers_")]
    public Controllers<EventData> EventControllers { get; set; } // FIXME: list of stage::quest::event::EventData? list structure is similar

    [JsonPropertyName("useOffset_")]
    public bool UseOffset { get; set; } = false;

    [JsonPropertyName("offsetUniqueIdHash_")]
    public ulong OffsetUniqueIdHash { get; set; } = 0;

    [JsonPropertyName("isFadeInEventAfter_")]
    public bool IsFadeInEventAfter { get; set; } = true;

    [JsonPropertyName("forceFadeTime_")]
    public float ForceFadeTime { get; set; } = 0;

    [JsonPropertyName("forceEndFadeTime_")]
    public float ForceEndFadeTime { get; set; } = 0;

    [JsonPropertyName("useMovePos_")]
    public bool UseMovePos { get; set; } = false;

    [JsonPropertyName("movePlayerPosHash_")]
    public BindingList<ulong> MovePlayerPosHash { get; set; } = []; // 4 elem

    [JsonPropertyName("moveGuestPosHash_")]
    public BindingList<ulong> MoveGuestPosHash { get; set; } = []; // 4 elem
}

/// <summary>
/// stage::quest::event::EventData
/// </summary>
[TypeConverter(typeof(ExpandableObjectConverter))]
public class EventData
{
    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("eventId")]
    public int EventId { get; set; }
}
