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

public class Em1600PositioningAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600PositioningAction);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0; // Offset 0x38

    public Em1600PositioningAction()
    {
    }
}


