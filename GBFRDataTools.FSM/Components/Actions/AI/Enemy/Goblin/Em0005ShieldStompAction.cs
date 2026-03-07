using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005ShieldStompAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005ShieldStompAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x3C

    [JsonPropertyName("loopNum_")]
    public int LoopNum { get; set; } = 3; // Offset 0x40

    [JsonPropertyName("loopEndRange_")]
    public float LoopEndRange { get; set; } = 10f; // Offset 0x44

    [JsonPropertyName("shieldDamage_")]
    public float ShieldDamage { get; set; } = 10f; // Offset 0x48

    public Em0005ShieldStompAction()
    {
    }
}

