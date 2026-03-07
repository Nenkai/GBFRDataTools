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

public class Em1600FlySpinTackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600FlySpinTackleAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 0.18f; // Offset 0x54

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 45f; // Offset 0x58

    public Em1600FlySpinTackleAction()
    {
    }
}

