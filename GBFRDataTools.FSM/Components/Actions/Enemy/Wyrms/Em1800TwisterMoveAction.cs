using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1800TwisterMoveAction : ShotMoveStraightAction
{
    [JsonPropertyName("waitRotationStart_")]
    public float WaitRotationStart { get; set; }

    [JsonPropertyName("targetDegreeX_")]
    public float TargetDegreeX { get; set; }

    [JsonPropertyName("targetDegreeY_")]
    public float TargetDegreeY { get; set; }

    [JsonPropertyName("rotationSecondX_")]
    public float RotationSecondX { get; set; }

    [JsonPropertyName("rotationSecondY_")]
    public float RotationSecondY { get; set; }

    [JsonPropertyName("reverseRotationX_")]
    public bool ReverseRotationX { get; set; }

    [JsonPropertyName("reverseRotationY_")]
    public bool ReverseRotationY { get; set; }

    [JsonPropertyName("velocityMaxSecond_")]
    public float VelocityMaxSecond { get; set; }
}
