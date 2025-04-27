using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800StepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800StepAction);

    [JsonPropertyName("isResetStep_")]
    public bool IsResetStep { get; set; } = false; // Offset 0x60

    [JsonPropertyName("motionIdNameStepFront_")]
    public string MotionIdNameStepFront { get; set; } // Offset 0x30

    [JsonPropertyName("motionIdNameStepBack_")]
    public string MotionIdNameStepBack { get; set; } // Offset 0x38

    [JsonPropertyName("motionIdNameStepLeft_")]
    public string MotionIdNameStepLeft { get; set; } // Offset 0x40

    [JsonPropertyName("motionIdNameStepRight_")]
    public string MotionIdNameStepRight { get; set; } // Offset 0x48

    public Em1800StepAction()
    {
    }
}
