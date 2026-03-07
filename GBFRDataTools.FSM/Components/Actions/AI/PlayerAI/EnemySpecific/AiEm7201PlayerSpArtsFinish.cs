using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

public class AiEm7201PlayerSpArtsFinish : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm7201PlayerSpArtsFinish);

    [JsonPropertyName("runAwayMaxDistanceSqr_")]
    public float RunAwayMaxDistanceSqr { get; set; }

    [JsonPropertyName("runAwayMinDistanceSqr_")]
    public float RunAwayMinDistanceSqr { get; set; }

    [JsonPropertyName("approachMinDistanceSqr_")]
    public float ApproachMinDistanceSqr { get; set; }
}
