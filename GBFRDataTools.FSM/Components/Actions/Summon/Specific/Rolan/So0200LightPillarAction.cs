using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Rolan;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So0200LightPillarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So0200LightPillarAction);

    [JsonPropertyName("baseDist_")]
    public float BaseDist { get; set; } = 4f;

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } = 8f;

    [JsonPropertyName("loopCount_")]
    public int LoopCount { get; set; } = 2;

    [JsonPropertyName("countMax_")]
    public int CountMax { get; set; } = 5;

    [JsonPropertyName("delaySeconds_")]
    public float DelaySeconds { get; set; } = 0.1f;
}