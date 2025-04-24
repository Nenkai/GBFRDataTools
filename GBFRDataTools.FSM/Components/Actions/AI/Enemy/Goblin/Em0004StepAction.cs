using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004StepAction);

    [JsonPropertyName("direction_")]
    public int Direction { get; set; } = 0; // Offset 0x54

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x58

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = 1f; // Offset 0x5C

    public Em0004StepAction()
    {
    }
}
