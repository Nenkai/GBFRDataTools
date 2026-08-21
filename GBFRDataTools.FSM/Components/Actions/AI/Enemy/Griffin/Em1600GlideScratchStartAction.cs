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
    public float TurningSpeed { get; set; } = 0.25f; 

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 45f; 

    [JsonPropertyName("riseSpd_")]
    public float RiseSpd { get; set; } = 7.5f; 

    [JsonPropertyName("moveSpd_")]
    public float MoveSpd { get; set; } = 90f; 

    [JsonPropertyName("minMoveLengthXZ_")]
    public float MinMoveLengthXZ { get; set; } = 10f; 

    [JsonPropertyName("maxMoveLengthXZ_")]
    public float MaxMoveLengthXZ { get; set; } = 60f; 

    [JsonPropertyName("adjustmentLengthXZ_")]
    public float AdjustmentLengthXZ { get; set; } = 8.5f; 
}

