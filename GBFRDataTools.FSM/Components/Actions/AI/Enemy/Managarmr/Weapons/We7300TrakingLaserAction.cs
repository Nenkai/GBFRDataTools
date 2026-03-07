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
    public float ChargeTime { get; set; } = 2f; // Offset 0x98

    [JsonPropertyName("trakingTime_")]
    public float TrakingTime { get; set; } = 10f; // Offset 0x9C

    [JsonPropertyName("trakingSpeed_")]
    public float TrakingSpeed { get; set; } = 2f; // Offset 0xA0

    [JsonPropertyName("postShotTime_")]
    public float PostShotTime { get; set; } = 0.5f; // Offset 0xA4

    [JsonPropertyName("noPowerWaitTime_")]
    public float NoPowerWaitTime { get; set; } = 5f; // Offset 0xA8

    public We7300TrakingLaserAction()
    {
    }
}
