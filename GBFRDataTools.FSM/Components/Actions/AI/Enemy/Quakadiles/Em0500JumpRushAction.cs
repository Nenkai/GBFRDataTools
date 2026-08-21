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
    public float TargetInFrontDistance { get; set; } = 4f; 

    [JsonPropertyName("jumpTimeRate_")]
    public float JumpTimeRate { get; set; } = 0.5f; 

    [JsonPropertyName("jumpHeight_")]
    public float JumpHeight { get; set; } = 2f; 

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 3.5f; 

    [JsonPropertyName("jumpHomingAngle_")]
    public float JumpHomingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("homingAngle_")]
    [Obsolete("Unused by the game")]
    [Description("Unused by the game")]
    public float HomingAngle { get; set; }

    [JsonPropertyName("distanceMinMax_")]
    public Vector2 DistanceMinMax { get; set; } = new Vector2(5f, 20f); 

    [JsonPropertyName("isTailSlash_")]
    public bool IsTailSlash { get; set; } = false; 
}


