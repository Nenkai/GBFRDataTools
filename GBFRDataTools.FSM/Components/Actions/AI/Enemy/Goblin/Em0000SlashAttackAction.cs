using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000SlashAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000SlashAttackAction);

    [JsonPropertyName("isStepMotion_")]
    public bool IsStepMotion { get; set; } = false; // Offset 0x35

    public Em0000SlashAttackAction()
    {
    }
}
