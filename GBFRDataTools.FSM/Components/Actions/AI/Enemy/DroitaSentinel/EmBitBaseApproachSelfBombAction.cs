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
    public float ApproachWaitSec { get; set; } = 1.5f; // Offset 0xC0

    [JsonPropertyName("approachMoveSpeed_")]
    public float ApproachMoveSpeed { get; set; } = 8f; // Offset 0xC4

    [JsonPropertyName("approachAffterSec_")]
    public float ApproachAffterSec { get; set; } = 3f; // Offset 0xC8

    [JsonPropertyName("initVelocity_")]
    public float InitVelocity { get; set; } = 2f; // Offset 0xB8

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 8f; // Offset 0xBC

    [JsonPropertyName("deceleration_")]
    public float Deceleration { get; set; } = 32f; // Offset 0xCC

    [JsonPropertyName("explosionRadius_")]
    public float ExplosionRadius { get; set; } = 3f; // Offset 0xD0

    [JsonPropertyName("dispEffectSec_")]
    public float DispEffectSec { get; set; } = 3.2f; // Offset 0xD4

    [JsonPropertyName("enableExplosionRadius_")]
    public float EnableExplosionRadius { get; set; } = 0.7f; // Offset 0xD8

    [JsonPropertyName("attackPower_")]
    public float AttackPower { get; set; } = 50f; // Offset 0xDC

    [JsonPropertyName("approachBombInterValMinSec_")]
    public float ApproachBombInterValMinSec { get; set; } = 3f; // Offset 0xE0

    [JsonPropertyName("approachBombInterValMaxSec_")]
    public float ApproachBombInterValMaxSec { get; set; } = 8f; // Offset 0xE4

    public EmBitBaseApproachSelfBombAction()
    {
    }
}
