using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0001MeleeAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0001MeleeAttackAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x50

    [JsonPropertyName("endTurnRate_")]
    public float EndTurnRate { get; set; } = 0.01f; // Offset 0x54

    [JsonPropertyName("escapeLoopNum_")]
    public int EscapeLoopNum { get; set; } = 2; // Offset 0x58

    [JsonPropertyName("escapeCheckDeg_")]
    public float EscapeCheckDeg { get; set; } = 45f; // Offset 0x5C

    [JsonPropertyName("frontStepMoveRate_")]
    public float FrontStepMoveRate { get; set; } = 1.5f; // Offset 0x60

    public Em0001MeleeAttackAction()
    {
    }
}

