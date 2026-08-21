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
    public float FirstAttackCancelTime { get; set; } = 1f; 

    [JsonPropertyName("wallStartMotionInterTime_")]
    public float WallStartMotionInterTime { get; set; } = 0.166f; 

    [JsonPropertyName("startTurnRate_")]
    public float StartTurnRate { get; set; } = 1f; 

    [JsonPropertyName("endTurnRate_")]
    public float EndTurnRate { get; set; } = 1f; 

    [JsonPropertyName("escapeRange_")]
    public float EscapeRange { get; set; } = 10f; 

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.1f; 

    [JsonPropertyName("createOffset_")]
    public Vector4 CreateOffset { get; set; } = new Vector4(0f, 0.5f, 0f, 1f); 
}

