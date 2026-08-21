using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000ChaseTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000ChaseTargetAction);

    [JsonPropertyName("homingRatePerSec_")]
    public float HomingRatePerSec { get; set; } = 2f; 

    [JsonPropertyName("timeOutSec_")]
    public float TimeOutSec { get; set; } = 10f;

    [JsonPropertyName("motionIdNameStart_")]
    public string? MotionIdNameStart { get; set; } = "0011";

    [JsonPropertyName("motionIdNameLoop_")]
    public string? MotionIdNameLoop { get; set; } = "0010";
}
