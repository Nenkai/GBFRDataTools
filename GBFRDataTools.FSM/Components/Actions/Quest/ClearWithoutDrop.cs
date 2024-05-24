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

public class ClearWithoutDrop : QuestActionComponent
{
    [JsonPropertyName("entityUniqueIdHash_")]
    public ulong EntityUniqueIdHash { get; set; }

    [JsonPropertyName("pointUniqueIdHash_")]
    public ulong PointUniqueIdHash { get; set; }

    [JsonPropertyName("bossEndPointIdHashs_")]
    public ulong BossEndPointIdHashs { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- EntityUniqueIdHash: {EntityUniqueIdHash}\n";
        str += $"- PointUniqueIdHash: {PointUniqueIdHash}\n";
        str += $"- BossEndPointIdHashs: {BossEndPointIdHashs}";

        return str;
    }
}
