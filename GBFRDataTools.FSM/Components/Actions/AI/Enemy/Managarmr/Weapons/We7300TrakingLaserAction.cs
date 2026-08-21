using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300TrakingLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300TrakingLaserAction);

    [JsonPropertyName("chargeTime_")]
    public float ChargeTime { get; set; } = 2f; 

    [JsonPropertyName("trakingTime_")]
    public float TrakingTime { get; set; } = 10f; 

    [JsonPropertyName("trakingSpeed_")]
    public float TrakingSpeed { get; set; } = 2f; 

    [JsonPropertyName("postShotTime_")]
    public float PostShotTime { get; set; } = 0.5f; 

    [JsonPropertyName("noPowerWaitTime_")]
    public float NoPowerWaitTime { get; set; } = 5f; 
}
