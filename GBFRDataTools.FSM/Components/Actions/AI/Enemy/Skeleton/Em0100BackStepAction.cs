using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100BackStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100BackStepAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.5f; // Offset 0x3C

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x40

    public Em0100BackStepAction()
    {
    }
}
