using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class FollowPlayerLiteAction : ActionComponent
{
    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; }

    [JsonPropertyName("turnMax_")]
    public float TurnMax { get; set; }

    [JsonPropertyName("stopFollowingDist_")]
    public float StopFollowingDist { get; set; }

    [JsonPropertyName("moveMotionName_")]
    public string MoveMotionName { get; set; }

    [JsonPropertyName("waitMotionName_")]
    public string WaitMotionName { get; set; }
}
