using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class ClearEndlessModeQuest : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ClearEndlessModeQuest);

    [JsonPropertyName("entityUniqueIdHash_")]
    [Description("Hash of a placement uuid.")]
    public ulong EntityUniqueIdHash { get; set; }

    [JsonPropertyName("pointUniqueIdHash_")]
    [Description("Hash of a placement uuid.")]
    public ulong PointUniqueIdHash { get; set; }

    [JsonPropertyName("bossEndPointIdHashs_")]
    [Description("Hash of a placement uuid.")]
    public ulong BossEndPointIdHashs { get; set; }

    [JsonPropertyName("portalUniqueIdHash_")]
    [Description("Hash of a placement uuid.")]
    public ulong PortalUniqueIdHash { get; set; }

    [JsonPropertyName("isBossDeadEvent_")]
    public bool IsBossDeadEvent { get; set; } = false;

    [JsonPropertyName("portalOffset_")]
    public float PortalOffset { get; set; } = 0f;

    [JsonPropertyName("treasureBoxOffset_")]
    public Vector2 TreasureBoxOffset { get; set; } = Vector2.Zero;
}
