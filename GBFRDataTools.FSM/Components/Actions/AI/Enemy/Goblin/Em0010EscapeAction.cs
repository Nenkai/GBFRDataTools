using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0010EscapeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0010EscapeAction);

    [JsonPropertyName("escapePresageShorteningNum_")]
    public int EscapePresageShorteningNum { get; set; }

    [JsonPropertyName("escapePresageSecMin_")]
    public float EscapePresageSecMin { get; set; }

    [JsonPropertyName("escapePresageSecMax_")]
    public int EscapePresageSecMax { get; set; }

    [JsonPropertyName("motionIdNamePresageLv1_")]
    public string? MotionIdNamePresageLv1 { get; set; }

    [JsonPropertyName("motionIdNamePresageLv2_")]
    public string? MotionIdNamePresageLv2 { get; set; }

    [JsonPropertyName("motionIdNameEscape_")]
    public string? MotionIdNameEscape { get; set; }
}