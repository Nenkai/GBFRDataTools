using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class FollowPlayerAction : ActionComponent
{
    [JsonPropertyName("speed_")]
    public float Speed { get; set; }

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; }

    [JsonPropertyName("turnMax_")]
    public float TurnMax { get; set; }

    [JsonPropertyName("forceWalk_")]
    public int ForceWalk { get; set; }

    [JsonPropertyName("startFollowingDist_")]
    public float StartFollowingDist { get; set; }

    [JsonPropertyName("stopFollowingDist_")]
    public float StopFollowingDist { get; set; }
}
