using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AIEm8100EscapeCombiSpArts : EmAINpcActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm8100EscapeCombiSpArts);

    [JsonPropertyName("escapeOffsetDir_")]
    public BindingList<float> EscapeOffsetDir { get; set; } = [.. Enumerable.Repeat(0.0f, 4)];

    [JsonPropertyName("arrivalThreshold_")]
    public float ArrivalThreshold { get; set; } = 22f;
}
