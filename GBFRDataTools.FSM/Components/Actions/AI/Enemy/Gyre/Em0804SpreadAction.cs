using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0804SpreadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0804SpreadAction);

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 0.5f; // Offset 0x4C

    [JsonPropertyName("waveWaitTime_")]
    public float WaveWaitTime { get; set; } = 0.5f; // Offset 0x50

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 1f; // Offset 0x54

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 1f; // Offset 0x58

    public Em0804SpreadAction()
    {
    }
}
