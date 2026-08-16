using GBFRDataTools.Entities;

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

[GameSupport(GameVersion.EndlessRagnarok)]
public class PreloadModelRequest : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PreloadModelRequest);

    [JsonPropertyName("uniqueId_")]
    public ulong UniqueId { get; set; }

    [JsonPropertyName("mipLv_")]
    public uint MipLv { get; set; } = 0;

    [JsonPropertyName("shadowLoad_")]
    public bool ShadowLoad { get; set; } = false;

    [JsonPropertyName("weaponLoad_")]
    public bool WeaponLoad { get; set; } = false;

    [JsonPropertyName("lodIndex_")]
    public byte LodIndex { get; set; } = 0;

    [JsonPropertyName("readCompCheck_")]
    public bool ReadCompCheck { get; set; } = false;
}
