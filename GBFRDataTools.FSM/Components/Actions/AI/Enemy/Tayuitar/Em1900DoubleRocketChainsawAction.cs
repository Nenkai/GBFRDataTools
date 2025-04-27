using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900DoubleRocketChainsawAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900DoubleRocketChainsawAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; // Offset 0x68

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 3f; // Offset 0x6C

    public Em1900DoubleRocketChainsawAction()
    {
    }
}

