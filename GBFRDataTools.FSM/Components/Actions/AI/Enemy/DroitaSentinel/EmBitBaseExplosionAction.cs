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

public class EmBitBaseExplosionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitBaseExplosionAction);

    [JsonPropertyName("dispEffectSec_")]
    public float DispEffectSec { get; set; } = 3.2f; // Offset 0x40

    public EmBitBaseExplosionAction()
    {
    }
}

