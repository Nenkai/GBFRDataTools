﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class FollowPlayerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FollowPlayerAction);

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 0.0f;

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; } = 0.0f;

    [JsonPropertyName("turnMax_")]
    public float TurnMax { get; set; } = 0.0f;

    [JsonPropertyName("forceWalk_")]
    public int ForceWalk { get; set; } = 0;

    [JsonPropertyName("startFollowingDist_")]
    public float StartFollowingDist { get; set; } = 0.0f;

    [JsonPropertyName("stopFollowingDist_")]
    public float StopFollowingDist { get; set; } = 0.0f;
}
