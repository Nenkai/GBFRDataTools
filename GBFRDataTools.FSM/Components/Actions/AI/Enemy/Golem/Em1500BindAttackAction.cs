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

public class Em1500BindAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BindAttackAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; // Offset 0x58

    [JsonPropertyName("moveLoopMax_")]
    public int MoveLoopMax { get; set; } = 3; // Offset 0x5C

    [JsonPropertyName("bindStartRange_")]
    public float BindStartRange { get; set; } = 2f; // Offset 0x60

    [JsonPropertyName("bindOffsetX_")]
    public float BindOffsetX { get; set; } = -0.5f; // Offset 0x64

    [JsonPropertyName("bindOffsetY_")]
    public float BindOffsetY { get; set; } = 0f; // Offset 0x68

    [JsonPropertyName("bindOffsetZ_")]
    public float BindOffsetZ { get; set; } = 0.5f; // Offset 0x6C

    public Em1500BindAttackAction()
    {
    }
}
