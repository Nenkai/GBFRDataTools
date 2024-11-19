using GBFRDataTools.FSM.Entities;
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

public class CallConsecutiveEvent : QuestActionComponent
{
    [JsonPropertyName("eventControllers_")]
    public Controllers<EventData> EventControllers { get; set; } // FIXME: list of stage::quest::event::EventData? list structure is similar

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
    public BindingList<ulong> MovePlayerPosHash { get; set; } // 4 elem

    [JsonPropertyName("moveGuestPosHash_")]
    public BindingList<ulong> MoveGuestPosHash { get; set; } // 4 elem

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}

/// <summary>
/// stage::quest::event::EventData
/// </summary>
public class EventData
{
    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("eventId")]
    public int EventId { get; set; }
}
