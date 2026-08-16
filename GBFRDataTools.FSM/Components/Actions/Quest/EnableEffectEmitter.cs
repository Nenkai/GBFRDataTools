using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Conditions.Quest;

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

public class EnableEffectEmitter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EnableEffectEmitter);

    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; } = 0;

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; } = 0;

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false;

    [JsonPropertyName("isMultiSelect_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsMultiSelect { get; set; } = false;

    [JsonPropertyName("additionalUpperUuids_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public BindingList<ulong> AdditionalUpperUuids { get; set; } = [];

    [JsonPropertyName("additionalLowerUuids_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public BindingList<ulong> AdditionalLowerUuids { get; set; } = [];

    [JsonPropertyName("isEffectTrigger_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsEffectTrigger { get; set; } = false;

    [JsonPropertyName("isIncludePrefab_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsIncludePrefab { get; set; } = false;
}
