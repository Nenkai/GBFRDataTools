using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004RushAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004RushAttackAction);

    [JsonPropertyName("startPhase_")]
    public int StartPhase { get; set; } = 0; // Offset 0x40

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 5f; // Offset 0x44

    [JsonPropertyName("loopHomingAngle_")]
    public float LoopHomingAngle { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("loopMotionSeconds_")]
    public float LoopMotionSeconds { get; set; } = 0.7f; // Offset 0x4C

    [JsonPropertyName("endDistance_")]
    public float EndDistance { get; set; } = 2f; // Offset 0x50

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 30f; // Offset 0x54

    [JsonPropertyName("endMoveRate_")]
    public float EndMoveRate { get; set; } = 0.5f; // Offset 0x58

    [JsonPropertyName("skipEnd_")]
    public bool SkipEnd { get; set; } = false; // Offset 0x5C

    public Em0004RushAttackAction()
    {
    }
}
