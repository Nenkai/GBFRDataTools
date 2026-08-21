using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class EmBitBaseApproachSelfBombAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitBaseApproachSelfBombAction);

    [JsonPropertyName("approachWaitSec_")]
    public float ApproachWaitSec { get; set; } = 1.5f; 

    [JsonPropertyName("approachMoveSpeed_")]
    public float ApproachMoveSpeed { get; set; } = 8f; 

    [JsonPropertyName("approachAffterSec_")]
    public float ApproachAffterSec { get; set; } = 3f; 

    [JsonPropertyName("initVelocity_")]
    public float InitVelocity { get; set; } = 2f; 

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 8f; 

    [JsonPropertyName("deceleration_")]
    public float Deceleration { get; set; } = 32f; 

    [JsonPropertyName("explosionRadius_")]
    public float ExplosionRadius { get; set; } = 3f; 

    [JsonPropertyName("dispEffectSec_")]
    public float DispEffectSec { get; set; } = 3.2f; 

    [JsonPropertyName("enableExplosionRadius_")]
    public float EnableExplosionRadius { get; set; } = 0.7f; 

    [JsonPropertyName("attackPower_")]
    public float AttackPower { get; set; } = 50f; 

    [JsonPropertyName("approachBombInterValMinSec_")]
    public float ApproachBombInterValMinSec { get; set; } = 3f; 

    [JsonPropertyName("approachBombInterValMaxSec_")]
    public float ApproachBombInterValMaxSec { get; set; } = 8f; 
}
