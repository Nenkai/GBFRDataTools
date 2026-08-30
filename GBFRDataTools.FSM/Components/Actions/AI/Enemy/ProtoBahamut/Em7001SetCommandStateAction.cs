using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001SetCommandStateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001SetCommandStateAction);

    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0; 

    [JsonPropertyName("pattern_")]
    public int Pattern { get; set; } = 0; 

    [JsonPropertyName("state_")]
    public int State { get; set; } = 0;

    [JsonPropertyName("isChaosChange_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsChaosChange { get; set; } = false;

    [JsonPropertyName("chaosPhase_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int ChaosPhase { get; set; } = 0;

    [JsonPropertyName("chaosPattern_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int ChaosPattern { get; set; } = 0;

    [JsonPropertyName("chaosState_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public int ChaosState { get; set; } = 0;
}
