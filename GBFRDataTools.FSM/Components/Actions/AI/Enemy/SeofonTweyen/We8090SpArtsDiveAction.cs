using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class We8090SpArtsDiveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We8090SpArtsDiveAction);

    [JsonPropertyName("waitLoopSec_")]
    public float WaitLoopSec { get; set; } = 1f;

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 5f;

    [JsonPropertyName("attackSignFrame_")]
    public int AttackSignFrame { get; set; } = 105;

    [JsonPropertyName("waveScaleSec_")]
    public float WaveScaleSec { get; set; } = 1.5f;
}