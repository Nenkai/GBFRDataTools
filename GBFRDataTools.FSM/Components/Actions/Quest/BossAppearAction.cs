using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class BossAppearAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BossAppearAction);

    [JsonPropertyName("mainBossUUID_")]
    public ulong MainBossUUID { get; set; } = 0;

    [JsonPropertyName("subBossUUID_")]
    public ulong SubBossUUID { get; set; } = 0;

    [JsonPropertyName("mainBossFSM_")]
    public string MainBossFSM { get; set; } = string.Empty;

    [JsonPropertyName("subBossFSM_")]
    public string SubBossFSM { get; set; } = string.Empty;

    [JsonPropertyName("mainBossSkipFSM_")]
    public string MainBossSkipFSM { get; set; } = "boss_appear_event_skip";

    [JsonPropertyName("subBossSkipFSM_")]
    public string SubBossSkipFSM { get; set; } = "boss_appear_event_skip";
}
