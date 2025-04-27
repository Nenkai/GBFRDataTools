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

public class We7300ChargeLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300ChargeLaserAction);

    [JsonPropertyName("chargeTime_")]
    public Vector4 ChargeTime { get; set; } = new Vector4(7f, 7f, 3f, 3f); // Offset 0x80

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1f; // Offset 0x90

    public We7300ChargeLaserAction()
    {
    }
}
