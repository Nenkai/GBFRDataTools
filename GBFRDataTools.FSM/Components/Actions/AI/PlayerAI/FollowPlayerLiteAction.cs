using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class FollowPlayerLiteAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FollowPlayerLiteAction);

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; } = 0.1f;

    [JsonPropertyName("turnMax_")]
    public float TurnMax { get; set; } = MathF.PI;

    [JsonPropertyName("stopFollowingDist_")]
    public float StopFollowingDist { get; set; } = 2.0f;

    [JsonPropertyName("moveMotionName_")]
    public string MoveMotionName { get; set; } = "0000";

    [JsonPropertyName("waitMotionName_")]
    public string WaitMotionName { get; set; } = "0000";
}
