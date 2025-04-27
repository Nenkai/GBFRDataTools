using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Vrazarek;

public class Em1801StepFireBallAction : Em1800StepFireBallAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1801StepFireBallAction);

    [JsonPropertyName("movementRate_")]
    public float MovementRate { get; set; } = 1f; // Offset 0x70

    public Em1801StepFireBallAction()
    {
    }
}
