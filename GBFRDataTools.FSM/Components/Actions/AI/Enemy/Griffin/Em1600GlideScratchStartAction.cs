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

public class Em1600GlideScratchStartAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600GlideScratchStartAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 0.25f; // Offset 0x6C

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 45f; // Offset 0x70

    [JsonPropertyName("riseSpd_")]
    public float RiseSpd { get; set; } = 7.5f; // Offset 0x74

    [JsonPropertyName("moveSpd_")]
    public float MoveSpd { get; set; } = 90f; // Offset 0x78

    [JsonPropertyName("minMoveLengthXZ_")]
    public float MinMoveLengthXZ { get; set; } = 10f; // Offset 0x7C

    [JsonPropertyName("maxMoveLengthXZ_")]
    public float MaxMoveLengthXZ { get; set; } = 60f; // Offset 0x80

    [JsonPropertyName("adjustmentLengthXZ_")]
    public float AdjustmentLengthXZ { get; set; } = 8.5f; // Offset 0x84

    public Em1600GlideScratchStartAction()
    {
    }
}

