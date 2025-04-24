using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100MoveToAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.2f; // Offset 0x40

    [JsonPropertyName("timeOutSec_")]
    public float TimeOutSec { get; set; } = 10f; // Offset 0x44

    [JsonPropertyName("completeRadius_")]
    public float CompleteRadius { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("motionIdNameMove_")]
    public string MotionIdNameMove { get; set; } // Offset 0x50

    public Em0100MoveToAction()
    {
    }
}
