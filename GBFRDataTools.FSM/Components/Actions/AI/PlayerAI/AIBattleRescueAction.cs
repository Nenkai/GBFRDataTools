using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Simulates a revive input from the player.")]
public class AIBattleRescueAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleRescueAction);

    [JsonPropertyName("timer_")]
    public float Timer { get; set; } = 0.0f;

    public override string? GetCaption()
    {
        return $"Timer: {Timer:F2}";
    }
}
