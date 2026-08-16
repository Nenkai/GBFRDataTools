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

public class ClearWithoutDrop : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearWithoutDrop);

    [JsonPropertyName("entityUniqueIdHash_")]
    [Description("Hash of a placement uuid.")]
    public ulong EntityUniqueIdHash { get; set; } = 0;

    [JsonPropertyName("pointUniqueIdHash_")]
    [Description("Hash of a placement uuid.")]
    public ulong PointUniqueIdHash { get; set; } = 0;

    [JsonPropertyName("bossEndPointIdHashs_")]
    [Description("Hash of a placement uuid.")]
    public ulong BossEndPointIdHashs { get; set; } = 0;

    public override string GetCaption()
    {
        var str = $"EntityUniqueIdHash: {EntityUniqueIdHash}\n";
        str += $"PointUniqueIdHash: {PointUniqueIdHash}\n";
        str += $"BossEndPointIdHashs: {BossEndPointIdHashs}";

        return str;
    }
}
