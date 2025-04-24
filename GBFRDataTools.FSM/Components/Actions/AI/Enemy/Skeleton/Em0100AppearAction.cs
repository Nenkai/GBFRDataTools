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
    public float Speed { get; set; } = 0.2f; // Offset 0x48

    [JsonPropertyName("speedRateA_")]
    public float SpeedRateA { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("speedRateB_")]
    public float SpeedRateB { get; set; } = 1f; // Offset 0x38

    [JsonPropertyName("speedRateC_")]
    public float SpeedRateC { get; set; } = 1f; // Offset 0x3C

    [JsonPropertyName("speedRateD_")]
    public float SpeedRateD { get; set; } = 1f; // Offset 0x40

    [JsonPropertyName("speedRateE_")]
    public float SpeedRateE { get; set; } = 1f; // Offset 0x44

    [JsonPropertyName("fallRate_")]
    public float FallRate { get; set; } = 0.5f; // Offset 0x4C

    public Em0100AppearAction()
    {
    }
}
