using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801FlyingBreathAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801FlyingBreathAction);

    [JsonPropertyName("maxMoveTime_")]
    public float MaxMoveTime { get; set; } = 3f; // Offset 0x48

    [JsonPropertyName("minMoveTime_")]
    public float MinMoveTime { get; set; } = 1f; // Offset 0x4C

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.01f; // Offset 0x50

    [JsonPropertyName("maxMovementRate_")]
    public float MaxMovementRate { get; set; } = 1.5f; // Offset 0x54

    [JsonPropertyName("minMovementRate_")]
    public float MinMovementRate { get; set; } = 1f; // Offset 0x58

    [JsonPropertyName("addMovementRate_")]
    public float AddMovementRate { get; set; } = 0.01f; // Offset 0x5C

    public Em1801FlyingBreathAction()
    {
    }
}
