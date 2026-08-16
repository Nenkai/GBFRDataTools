using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetModelTransAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetModelTransAction);

    [JsonPropertyName("isTrans_")]
    public bool IsTrans { get; set; } = true;

    [JsonPropertyName("isSeqOff_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsSeqOff { get; set; } = false;

    [JsonPropertyName("isStartExecution_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsStartExecution { get; set; } = false;
}