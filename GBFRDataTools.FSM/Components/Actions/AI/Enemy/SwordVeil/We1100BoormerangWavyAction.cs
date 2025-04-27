using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class We1100BoormerangWavyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1100BoormerangWavyAction);

    [JsonPropertyName("attackDistance_")]
    public float AttackDistance { get; set; } = 15f; // Offset 0x40

    [JsonPropertyName("swordMoveSpeed_")]
    public float SwordMoveSpeed { get; set; } = 12f; // Offset 0x44

    [JsonPropertyName("stopSec_")]
    public float StopSec { get; set; } = 0.5f; // Offset 0x48

    public We1100BoormerangWavyAction()
    {
    }
}
