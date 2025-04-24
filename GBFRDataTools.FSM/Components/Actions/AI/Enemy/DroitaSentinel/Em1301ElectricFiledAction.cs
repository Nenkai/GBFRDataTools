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

public class Em1301ElectricFiledAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301ElectricFiledAction);

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } = 3f; // Offset 0x40

    public Em1301ElectricFiledAction()
    {
    }
}
