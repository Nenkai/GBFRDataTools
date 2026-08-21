using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0003MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0003MoveToAction);

    [JsonPropertyName("groundMoveMotionId_")]
    public string? GroundMoveMotionId { get; set; } 

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 4f; 

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 1f; 

    [JsonPropertyName("jumpTurnRate_")]
    public float JumpTurnRate { get; set; } = 1f; 

    [JsonPropertyName("moveEndRange_")]
    public float MoveEndRange { get; set; } = 25f; 
}
