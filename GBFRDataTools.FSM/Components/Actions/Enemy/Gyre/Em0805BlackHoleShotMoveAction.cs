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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Gyre;

public class Em0805BlackHoleShotMoveAction : ShotMoveStraightAction
{
    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; }

    [JsonPropertyName("isHoming_")]
    public bool IsHoming { get; set; }

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; }

    [JsonPropertyName("stopDistance_")]
    public float StopDistance { get; set; }

    [JsonPropertyName("noStopTime_")]
    public float NoStopTime { get; set; }

    [JsonPropertyName("stopDegree_")]
    public float StopDegree { get; set; }

    [JsonPropertyName("isStopDistanceAndAngle_")]
    public bool IsStopDistanceAndAngle { get; set; }

    [JsonPropertyName("isHomingOnlyY_")]
    public bool IsHomingOnlyY { get; set; }

    [JsonPropertyName("isCheckRotate_")]
    public bool IsCheckRotate { get; set; }

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; }

    [JsonPropertyName("checkNum_")]
    public int CheckNum { get; set; }

    [JsonPropertyName("checkHeight_")]
    public float CheckHeight { get; set; }

    [JsonPropertyName("checkAdjustHeight_")]
    public float CheckAdjustHeight { get; set; }

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; }
}
