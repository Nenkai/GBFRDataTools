using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0800ExplosionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0800ExplosionAction);

    [JsonPropertyName("dispEffectSec_")]
    public float DispEffectSec { get; set; } = 3.2f; // Offset 0x40

    public Em0800ExplosionAction()
    {
    }
}
