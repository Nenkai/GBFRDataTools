using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class BossAppearAction : QuestActionComponent
{
    [JsonPropertyName("mainBossUUID_")]
    public ulong MainBossUUID { get; set; }

    [JsonPropertyName("subBossUUID_")]
    public ulong SubBossUUID { get; set; }

    [JsonPropertyName("mainBossFSM_")]
    public string MainBossFSM { get; set; }

    [JsonPropertyName("subBossFSM_")]
    public string SubBossFSM { get; set; }

    [JsonPropertyName("mainBossSkipFSM_")]
    public string MainBossSkipFSM { get; set; }

    [JsonPropertyName("subBossSkipFSM_")]
    public string SubBossSkipFSM { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
