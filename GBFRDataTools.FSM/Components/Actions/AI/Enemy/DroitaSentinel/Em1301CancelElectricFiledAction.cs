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

public class Em1301CancelElectricFiledAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301CancelElectricFiledAction);

    [JsonPropertyName("staggeSec_")]
    public float StaggeSec { get; set; } = 3f; // Offset 0x40

    public Em1301CancelElectricFiledAction()
    {
    }
}
