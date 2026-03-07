using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004JumpAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004JumpAttackAction);

    [JsonPropertyName("firstHomingAngle_")]
    public float FirstHomingAngle { get; set; } = 3f; // Offset 0x38

    [JsonPropertyName("secondHomingAngle_")]
    public float SecondHomingAngle { get; set; } = 3f; // Offset 0x3C

    [JsonPropertyName("moveDistance_")]
    public float MoveDistance { get; set; } = 1.5f; // Offset 0x40

    [JsonPropertyName("moveRateMax_")]
    public float MoveRateMax { get; set; } = 3f; // Offset 0x44

    [JsonPropertyName("moveRateMin_")]
    public float MoveRateMin { get; set; } = 0.1f; // Offset 0x48

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = -1f; // Offset 0x4C

    [JsonPropertyName("skipSecond_")]
    public bool SkipSecond { get; set; } = false; // Offset 0x50

    public Em0004JumpAttackAction()
    {
    }
}
