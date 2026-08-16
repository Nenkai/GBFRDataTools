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
public class AiEm8200OdartsAction : EmAINpcActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm8200OdartsAction);

    [JsonPropertyName("playerOffsetDist_")]
    public float PlayerOffsetDist { get; set; } = 6f;

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } = 1f;

    [JsonPropertyName("offsetDistArrived_")]
    public float OffsetDistArrived { get; set; } = 3f;
}
