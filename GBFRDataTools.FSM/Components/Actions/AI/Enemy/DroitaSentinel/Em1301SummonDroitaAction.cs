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

public class Em1301SummonDroitaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301SummonDroitaAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x70

    public Em1301SummonDroitaAction()
    {
    }
}
