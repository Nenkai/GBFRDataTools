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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900PunishmentBarrierAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900PunishmentBarrierAction);

    [JsonPropertyName("fragmentNum_")]
    public int FragmentNum { get; set; } = 10; 

    [JsonPropertyName("isSuper_")]
    public bool IsSuper { get; set; } = false;

    [JsonPropertyName("isG3_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsG3 { get; set; } = false;

    [JsonPropertyName("g3StartWaitTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float G3StartWaitTime { get; set; } = 1.52f;

    [JsonPropertyName("g3ExpandWaitTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float G3ExpandWaitTime { get; set; } = 1f;

    [JsonPropertyName("g3ExpandTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float G3ExpandTime { get; set; } = 2.1f;

    [JsonPropertyName("g3ExpandEndLength_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float G3ExpandEndLength { get; set; } = 33f;

    [JsonPropertyName("g3ExpandStartLength_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public float G3ExpandStartLength { get; set; } = 10f;

}