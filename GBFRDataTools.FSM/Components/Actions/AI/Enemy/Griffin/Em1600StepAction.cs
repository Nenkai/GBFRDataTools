using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600StepAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 0.2f; // Offset 0x34

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 45f; // Offset 0x38

    public Em1600StepAction()
    {
    }
}


