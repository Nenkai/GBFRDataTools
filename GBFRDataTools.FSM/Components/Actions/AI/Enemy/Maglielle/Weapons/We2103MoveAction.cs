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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2103MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2103MoveAction);

    [JsonPropertyName("rotationDeg_")]
    public Vector4 RotationDeg { get; set; } = new Vector4(-90f, 0f, 0f, 1f); 

    [JsonPropertyName("moveDirY_")]
    public float MoveDirY { get; set; } = 0f; 

    [JsonPropertyName("moveDistance_")]
    public float MoveDistance { get; set; } = 2f; 

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 0.5f; 

    [JsonPropertyName("moveDir_")]
    [Obsolete("Not used by the game")]
    [Description("Not used by the game")]
    public Vector4 MoveDir { get; set; }
}
