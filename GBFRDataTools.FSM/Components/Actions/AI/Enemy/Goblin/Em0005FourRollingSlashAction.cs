using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005FourRollingSlashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005FourRollingSlashAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x40

    [JsonPropertyName("minMovementRate_")]
    public float MinMovementRate { get; set; } = 0.5f; // Offset 0x44

    [JsonPropertyName("maxMovementRate_")]
    public float MaxMovementRate { get; set; } = 1.5f; // Offset 0x48

    [JsonPropertyName("minCalcMovementDist_")]
    public float MinCalcMovementDist { get; set; } = 5f; // Offset 0x4C

    [JsonPropertyName("maxCalcMovementDist_")]
    public float MaxCalcMovementDist { get; set; } = 20f; // Offset 0x50

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 5f; // Offset 0x54

    public Em0005FourRollingSlashAction()
    {
    }
}


