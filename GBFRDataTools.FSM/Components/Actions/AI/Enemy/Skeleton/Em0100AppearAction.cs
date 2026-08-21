using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100AppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100AppearAction);

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } = 0.2f; 

    [JsonPropertyName("speedRateA_")]
    public float SpeedRateA { get; set; } = 1f; 

    [JsonPropertyName("speedRateB_")]
    public float SpeedRateB { get; set; } = 1f; 

    [JsonPropertyName("speedRateC_")]
    public float SpeedRateC { get; set; } = 1f; 

    [JsonPropertyName("speedRateD_")]
    public float SpeedRateD { get; set; } = 1f; 

    [JsonPropertyName("speedRateE_")]
    public float SpeedRateE { get; set; } = 1f; 

    [JsonPropertyName("fallRate_")]
    public float FallRate { get; set; } = 0.5f; 
}
