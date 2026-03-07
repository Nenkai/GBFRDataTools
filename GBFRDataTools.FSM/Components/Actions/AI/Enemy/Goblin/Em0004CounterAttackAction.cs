using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004CounterAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004CounterAttackAction);

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 0.7f; // Offset 0x30

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x34

    public Em0004CounterAttackAction()
    {
    }
}
