using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.NavMesh;

public class NavMeshMovePassAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(NavMeshMovePassAction);

    [JsonPropertyName("targetPosition_")]
    public /* cVec4 */ Vector4 TargetPosition { get; set; } = Vector4.UnitW;

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; } = 180.0f;

    [JsonPropertyName("endDistance_")]
    public float EndDistance { get; set; } = 1.0f;

    [JsonPropertyName("motionIdMoveStart_")]
    public string MotionIdMoveStart { get; set; } = "0011";

    [JsonPropertyName("motionIdMoveLoop_")]
    public string MotionIdMoveLoop { get; set; } = "0010";

    [JsonPropertyName("motionIdMoveEnd_")]
    public string MotionIdMoveEnd { get; set; } = "0012";
}
