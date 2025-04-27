using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

public class AIWarpPointDistanceCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIWarpPointDistanceCondition);

    [JsonPropertyName("dist_")]
    public float Dist { get; set; } = 10f; // Offset 0x38

    [JsonPropertyName("delayTime_")]
    public float DelayTime { get; set; } = 0f; // Offset 0x40

    public AIWarpPointDistanceCondition()
    {
    }
}
