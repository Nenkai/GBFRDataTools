using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0001CounterAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0001CounterAttackAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x40

    [JsonPropertyName("firstAttackCancelTime_")]
    public float FirstAttackCancelTime { get; set; } = 1f; // Offset 0x44

    [JsonPropertyName("lastAttackInterTime_")]
    public float LastAttackInterTime { get; set; } = 0.333f; // Offset 0x48

    public Em0001CounterAttackAction()
    {
    }
}
