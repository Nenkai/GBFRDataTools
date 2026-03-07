using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1301ElectricPulseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301ElectricPulseAction);

    [JsonPropertyName("initPulseScale_")]
    public float InitPulseScale { get; set; } = 1f; // Offset 0x90

    [JsonPropertyName("pulseAttackRate_")]
    public float PulseAttackRate { get; set; } = 1f; // Offset 0x94

    [JsonPropertyName("pulseVelocity_")]
    public float PulseVelocity { get; set; } = 8f; // Offset 0x98

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } = 1f; // Offset 0x9C

    [JsonPropertyName("shootPulseAngleFromTargetDir_")]
    public BindingList<float> ShootPulseAngleFromTargetDir { get; set; } = []; // Offset 0xC0

    [JsonPropertyName("waitShootEndSec_")]
    public float WaitShootEndSec { get; set; } = 3f; // Offset 0xA0

    [JsonPropertyName("shootIntervalSec_")]
    public float ShootIntervalSec { get; set; } = 1f; // Offset 0xA4

    public Em1301ElectricPulseAction()
    {
    }
}
