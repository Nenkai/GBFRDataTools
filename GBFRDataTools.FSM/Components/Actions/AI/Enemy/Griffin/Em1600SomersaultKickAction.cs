using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600SomersaultKickAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600SomersaultKickAction);

    [JsonPropertyName("minMoveDist_")]
    public float MinMoveDist { get; set; } = 3f; // Offset 0x38

    [JsonPropertyName("maxMoveDist_")]
    public float MaxMoveDist { get; set; } = 15f; // Offset 0x3C

    [JsonPropertyName("movementRateXZ_")]
    public float MovementRateXZ { get; set; } = 1f; // Offset 0x40

    [JsonPropertyName("movementRateY_")]
    public float MovementRateY { get; set; } = 1f; // Offset 0x44

    public Em1600SomersaultKickAction()
    {
    }
}

