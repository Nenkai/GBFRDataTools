using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Em3000;

public class Em3000SupportAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3000SupportAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("buffType_")]
    public int BuffType { get; set; } = 0; // Offset 0x44

    [JsonPropertyName("buffRate_")]
    public float BuffRate { get; set; } = 0.1f; // Offset 0x48

    [JsonPropertyName("buffTime_")]
    public float BuffTime { get; set; } = 30f; // Offset 0x4C

    public Em3000SupportAction()
    {
    }
}
