using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ClearWithDrop : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearWithDrop);

    [JsonPropertyName("entityUniqueIdHash_")]
    public ulong EntityUniqueIdHash { get; set; } = 0;

    [JsonPropertyName("pointUniqueIdHash_")]
    public ulong PointUniqueIdHash { get; set; } = 0;

    [JsonPropertyName("bossEndPointIdHashs_")]
    public ulong BossEndPointIdHashs { get; set; } = 0;

    [JsonPropertyName("isBossBattle_")]
    public bool IsBossBattle { get; set; } = true;
}
