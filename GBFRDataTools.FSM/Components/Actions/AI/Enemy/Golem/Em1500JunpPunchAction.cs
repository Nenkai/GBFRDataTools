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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500JunpPunchAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500JunpPunchAction);

    [JsonPropertyName("hardModeExActionLoopNum_")]
    public int HardModeExActionLoopNum { get; set; } = 0;

    [JsonPropertyName("turnRate_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float TurnRate { get; set; } = -1f;

    [JsonPropertyName("jumpSkip_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public bool JumpSkip { get; set; } = false;

    [JsonPropertyName("jumpSkipStartSec_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float JumpSkipStartSec { get; set; } = -1f;

    [JsonPropertyName("jumpSkipInterSec_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float JumpSkipInterSec { get; set; } = -1f;

    [JsonPropertyName("jumpSkipEndSec_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok")]
    public float JumpSkipEndSec { get; set; } = -1f;
}