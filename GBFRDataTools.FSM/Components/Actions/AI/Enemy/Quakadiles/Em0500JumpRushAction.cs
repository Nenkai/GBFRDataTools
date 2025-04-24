using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500JumpRushAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500JumpRushAction);

    [JsonPropertyName("targetInFrontDistance_")]
    public float TargetInFrontDistance { get; set; } = 4f; // Offset 0x60

    [JsonPropertyName("jumpTimeRate_")]
    public float JumpTimeRate { get; set; } = 0.5f; // Offset 0x64

    [JsonPropertyName("jumpHeight_")]
    public float JumpHeight { get; set; } = 2f; // Offset 0x68

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 3.5f; // Offset 0x6C

    [JsonPropertyName("jumpHomingAngle_")]
    public float JumpHomingAngle { get; set; } = 0.5f; // Offset 0x70

    [JsonPropertyName("homingAngle_")]
    [Obsolete("Unused by the game")]
    [Description("Unused by the game")]
    public float HomingAngle { get; set; }

    [JsonPropertyName("distanceMinMax_")]
    public Vector2 DistanceMinMax { get; set; } = new Vector2(5f, 20f); // Offset 0x74

    [JsonPropertyName("isTailSlash_")]
    public bool IsTailSlash { get; set; } = false; // Offset 0x7C

    public Em0500JumpRushAction()
    {
    }
}


