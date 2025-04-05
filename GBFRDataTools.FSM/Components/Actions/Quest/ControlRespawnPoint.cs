using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ControlRespawnPoint : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlRespawnPoint);

    [JsonPropertyName("updateType_")]
    public int UpdateType { get; set; } = 0;

    [JsonPropertyName("zoneHash_")]
    public ulong ZoneHash { get; set; } = 0;
}
