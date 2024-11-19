using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class AiEm7201PlayerSpArtsFinish : ActionComponent
{
    [JsonPropertyName("runAwayMaxDistanceSqr_")]
    public float RunAwayMaxDistanceSqr { get; set; }

    [JsonPropertyName("runAwayMinDistanceSqr_")]
    public float RunAwayMinDistanceSqr { get; set; }

    [JsonPropertyName("approachMinDistanceSqr_")]
    public float ApproachMinDistanceSqr { get; set; }
}
