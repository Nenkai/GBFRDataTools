using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class NavMeshMovePassAction : ActionComponent
{
    [JsonPropertyName("targetPosition_")]
    public cVec4 TargetPosition { get; set; }

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; }

    [JsonPropertyName("endDistance_")]
    public float EndDistance { get; set; }

    [JsonPropertyName("motionIdMoveStart_")]
    public string MotionIdMoveStart { get; set; }

    [JsonPropertyName("motionIdMoveLoop_")]
    public string MotionIdMoveLoop { get; set; }

    [JsonPropertyName("motionIdMoveEnd_")]
    public string MotionIdMoveEnd { get; set; }
}
