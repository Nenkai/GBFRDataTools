using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AIEm7300PowerExEscapeAction : EmAINpcActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIEm7300PowerExEscapeAction);

    [JsonPropertyName("targetDist_")]
    [Obsolete("Not exposed by the executable")]
    public float TargetDist { get; set; }
}
