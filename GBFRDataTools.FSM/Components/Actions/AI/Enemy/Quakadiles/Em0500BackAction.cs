using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500BackAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500BackAction);

    [JsonPropertyName("homingAngleFront_")]
    public float HomingAngleFront { get; set; } = 8f; // Offset 0x44

    [JsonPropertyName("homingAngleLR_")]
    public float HomingAngleLR { get; set; } = 5f; // Offset 0x48

    [JsonPropertyName("homingAngleBack_")]
    public float HomingAngleBack { get; set; } = 3f; // Offset 0x4C

    [JsonPropertyName("endSecond_")]
    public float EndSecond { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; // Offset 0x54

    [JsonPropertyName("useDragMotion_")]
    public bool UseDragMotion { get; set; } = true; // Offset 0x58

    [JsonPropertyName("magmaConfront_")]
    public bool MagmaConfront { get; set; } = false; // Offset 0x59

    public Em0500BackAction()
    {
    }
}


