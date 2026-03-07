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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ToCenterStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ToCenterStepAction);

    [JsonPropertyName("checkStepDist_")]
    public float CheckStepDist { get; set; } = 10f; // Offset 0x34

    public Em1700ToCenterStepAction()
    {
    }
}
