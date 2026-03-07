using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1001SpearRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1001SpearRushAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; // Offset 0x40

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0x44

    [JsonPropertyName("attackStartDelay_")]
    public float AttackStartDelay { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("rushDist_")]
    public float RushDist { get; set; } = 30f; // Offset 0x50

    [JsonPropertyName("readyTime_")]
    public float ReadyTime { get; set; } = 2f; // Offset 0x4C

    public Em1001SpearRushAction()
    {
    }
}