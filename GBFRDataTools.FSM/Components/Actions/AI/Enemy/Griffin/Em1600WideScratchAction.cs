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

public class Em1600WideScratchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600WideScratchAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 0.06f; // Offset 0x30

    [JsonPropertyName("maxTurningAngle_")]
    public float MaxTurningAngle { get; set; } = 20f; // Offset 0x34

    public Em1600WideScratchAction()
    {
    }
}


