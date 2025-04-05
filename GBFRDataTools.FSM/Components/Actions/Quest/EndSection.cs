using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class EndSection : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndSection);

    [JsonPropertyName("controllers_")]
    public Controllers<UniqueId> Controllers { get; set; } = [];

    [JsonPropertyName("routineControllers_")]
    public Controllers<RoutineController> RoutineControllers { get; set; } = [];

    [JsonPropertyName("cleanupTimelineEvent_")]
    public bool CleanupTimelineEvent { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}

/// <summary>
/// BT::EndSection::RoutineControllers
/// </summary>
public class RoutineController
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;

    [JsonPropertyName("no_")]
    public ulong Number { get; set; } = 0;
}