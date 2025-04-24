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
    public string GroundMoveMotionId { get; set; } // Offset 0x38

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 4f; // Offset 0x40

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 1f; // Offset 0x70

    [JsonPropertyName("jumpTurnRate_")]
    public float JumpTurnRate { get; set; } = 1f; // Offset 0x74

    [JsonPropertyName("moveEndRange_")]
    public float MoveEndRange { get; set; } = 25f; // Offset 0x78

    public Em0003MoveToAction()
    {
    }
}
