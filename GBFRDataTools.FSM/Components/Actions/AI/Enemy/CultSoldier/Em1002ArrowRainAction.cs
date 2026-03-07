using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002ArrowRainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002ArrowRainAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f; // Offset 0x40

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = 0.5235988f; // Offset 0x44

    [JsonPropertyName("attackStartDelay_")]
    public float AttackStartDelay { get; set; } = 1f; // Offset 0x48

    public Em1002ArrowRainAction()
    {
    }
}