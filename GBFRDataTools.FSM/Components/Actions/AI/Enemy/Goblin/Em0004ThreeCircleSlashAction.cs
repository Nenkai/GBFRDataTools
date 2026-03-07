using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004ThreeCircleSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004ThreeCircleSlashAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x40

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 0.7f; // Offset 0x44

    [JsonPropertyName("wobbleTime_")]
    public float WobbleTime { get; set; } = 1f; // Offset 0x48

    public Em0004ThreeCircleSlashAction()
    {
    }
}
