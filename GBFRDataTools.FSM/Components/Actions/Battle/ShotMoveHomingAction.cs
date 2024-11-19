using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveHomingAction : ShotMoveStraightAction
{
    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; }

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; }

    [JsonPropertyName("stopDegree_")]
    public float StopDegree { get; set; }

    [JsonPropertyName("isStopDistanceAndAngle_")]
    public bool IsStopDistanceAndAngle { get; set; }

    [JsonPropertyName("isHomingOnlyY_")]
    public bool IsHomingOnlyY { get; set; }

    [JsonPropertyName("isRotateXY_")]
    public bool IsRotateXY { get; set; }
}
