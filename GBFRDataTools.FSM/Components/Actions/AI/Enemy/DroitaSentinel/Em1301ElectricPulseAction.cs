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
    public float InitPulseScale { get; set; } = 1f; 

    [JsonPropertyName("pulseAttackRate_")]
    public float PulseAttackRate { get; set; } = 1f; 

    [JsonPropertyName("pulseVelocity_")]
    public float PulseVelocity { get; set; } = 8f; 

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } = 1f; 

    [JsonPropertyName("shootPulseAngleFromTargetDir_")]
    public BindingList<float> ShootPulseAngleFromTargetDir { get; set; } = []; 

    [JsonPropertyName("waitShootEndSec_")]
    public float WaitShootEndSec { get; set; } = 3f; 

    [JsonPropertyName("shootIntervalSec_")]
    public float ShootIntervalSec { get; set; } = 1f; 
}
