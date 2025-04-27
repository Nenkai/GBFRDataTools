using GBFRDataTools.FSM.Components.Actions.AI.Enemy;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300BackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300BackAction);

    [JsonPropertyName("homingAngleFront_")]
    public float HomingAngleFront { get; set; } = 8f; // Offset 0x40

    [JsonPropertyName("homingAngleLR_")]
    public float HomingAngleLR { get; set; } = 5f; // Offset 0x44

    [JsonPropertyName("homingAngleBack_")]
    public float HomingAngleBack { get; set; } = 3f; // Offset 0x48

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; // Offset 0x4C

    [JsonPropertyName("beforeHevyRush_")]
    public bool BeforeHevyRush { get; set; } = false; // Offset 0x50

    public Em7300BackAction()
    {
    }
}
