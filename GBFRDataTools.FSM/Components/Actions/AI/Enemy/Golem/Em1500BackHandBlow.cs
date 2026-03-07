using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500BackHandBlow : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BackHandBlow);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x40

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 4; // Offset 0x44

    [JsonPropertyName("shotRotX_")]
    public float ShotRotX { get; set; } = 0.15f; // Offset 0x48

    [JsonPropertyName("shotIntervalTime_")]
    public float ShotIntervalTime { get; set; } = 0.016f; // Offset 0x4C

    public Em1500BackHandBlow()
    {
    }
}
