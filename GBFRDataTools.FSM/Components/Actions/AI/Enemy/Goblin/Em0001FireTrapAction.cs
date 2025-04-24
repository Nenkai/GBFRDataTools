using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0001FireTrapAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0001FireTrapAction);

    [JsonPropertyName("firstAttackCancelTime_")]
    public float FirstAttackCancelTime { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("wallStartMotionInterTime_")]
    public float WallStartMotionInterTime { get; set; } = 0.166f; // Offset 0x54

    [JsonPropertyName("startTurnRate_")]
    public float StartTurnRate { get; set; } = 1f; // Offset 0x58

    [JsonPropertyName("endTurnRate_")]
    public float EndTurnRate { get; set; } = 1f; // Offset 0x5C

    [JsonPropertyName("escapeRange_")]
    public float EscapeRange { get; set; } = 10f; // Offset 0x60

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.1f; // Offset 0x64

    [JsonPropertyName("createOffset_")]
    public Vector4 CreateOffset { get; set; } = new Vector4(0f, 0.5f, 0f, 1f); // Offset 0x70

    public Em0001FireTrapAction()
    {
    }
}

