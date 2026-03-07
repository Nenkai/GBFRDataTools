using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300ScratchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300ScratchAction);

    [JsonPropertyName("height_")]
    public float Height { get; set; } = 1.6f; // Offset 0x50

    [JsonPropertyName("attackHeight_")]
    public float AttackHeight { get; set; } = 0.5f; // Offset 0x54

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x58

    [JsonPropertyName("motionMoveValue_")]
    public float MotionMoveValue { get; set; } = 0.7f; // Offset 0x5C

    [JsonPropertyName("motionMoveRate_")]
    public Vector2 MotionMoveRate { get; set; } = new Vector2(0.5f, 2.5f); // Offset 0x60

    [JsonPropertyName("isCounter_")]
    public bool IsCounter { get; set; } = false; // Offset 0x68

    public Em0300ScratchAction()
    {
    }
}
