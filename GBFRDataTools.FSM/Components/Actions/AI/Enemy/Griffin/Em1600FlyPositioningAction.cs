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

public class Em1600FlyPositioningAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600FlyPositioningAction);

    [JsonPropertyName("stepType_")]
    public int StepType { get; set; } = 0; // Offset 0x50

    [JsonPropertyName("animMovementRate_")]
    public float AnimMovementRate { get; set; } = 1f; // Offset 0x54

    public Em1600FlyPositioningAction()
    {
    }
}


