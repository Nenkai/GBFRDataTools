using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Slime;

public class EmSlimeBaseRunAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSlimeBaseRunAction);

    [JsonPropertyName("isRight_")]
    public bool IsRight { get; set; } = true; 

    [JsonPropertyName("isAttack_")]
    public bool IsAttack { get; set; } = false; 

    [JsonPropertyName("isRotateToTarget_")]
    public bool IsRotateToTarget { get; set; } = false; 

    [JsonPropertyName("rotateMaxAngle_")]
    public float RotateMaxAngle { get; set; } = 90f; 

    [JsonPropertyName("escapeAngle_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float EscapeAngle { get; set; }

    [JsonPropertyName("moveAngle_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float MoveAngle { get; set; }

    [JsonPropertyName("moveTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float MoveTime { get; set; }

    [JsonPropertyName("checkHitMoveDist_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float CheckMoveHitDist { get; set; }

    [JsonPropertyName("boundMax_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float BoundMax { get; set; }

    [JsonPropertyName("lastMoveTime_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public float LastMoveTime { get; set; }
}
