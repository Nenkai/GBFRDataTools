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
    public bool IsRight { get; set; } = true; // Offset 0x9C

    [JsonPropertyName("isAttack_")]
    public bool IsAttack { get; set; } = false; // Offset 0x9D

    [JsonPropertyName("isRotateToTarget_")]
    public bool IsRotateToTarget { get; set; } = false; // Offset 0x9E

    [JsonPropertyName("rotateMaxAngle_")]
    public float RotateMaxAngle { get; set; } = 90f; // Offset 0xA0

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

    public EmSlimeBaseRunAction()
    {
    }
}
