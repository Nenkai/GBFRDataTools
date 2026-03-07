using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900JumpMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900JumpMoveAction);

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.1f; // Offset 0x70

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f; // Offset 0x74

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f; // Offset 0x78

    public Em1900JumpMoveAction()
    {
    }
}


