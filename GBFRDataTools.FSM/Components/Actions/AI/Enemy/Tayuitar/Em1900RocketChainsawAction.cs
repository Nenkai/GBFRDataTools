using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900RocketChainsawAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900RocketChainsawAction);

    [JsonPropertyName("isLeftArm_")]
    public bool IsLeftArm { get; set; } = false; // Offset 0x50

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; // Offset 0x54

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 3f; // Offset 0x58

    public Em1900RocketChainsawAction()
    {
    }
}


