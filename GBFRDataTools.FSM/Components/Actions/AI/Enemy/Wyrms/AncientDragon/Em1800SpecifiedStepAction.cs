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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800SpecifiedStepAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800SpecifiedStepAction);

    [JsonPropertyName("motionIdNameStepFront_")]
    public string MotionIdNameStepFront { get; set; } // Offset 0x70

    [JsonPropertyName("motionIdNameStepBack_")]
    public string MotionIdNameStepBack { get; set; } // Offset 0x78

    [JsonPropertyName("motionIdNameStepLeft_")]
    public string MotionIdNameStepLeft { get; set; } // Offset 0x80

    [JsonPropertyName("motionIdNameStepRight_")]
    public string MotionIdNameStepRight { get; set; } // Offset 0x88

    [JsonPropertyName("isOverrideHomingFront_")]
    public bool IsOverrideHomingFront { get; set; } = false; // Offset 0xB4

    [JsonPropertyName("isOverrideHomingBack_")]
    public bool IsOverrideHomingBack { get; set; } = false; // Offset 0xB5

    [JsonPropertyName("isOverrideHomingLeft_")]
    public bool IsOverrideHomingLeft { get; set; } = false; // Offset 0xB6

    [JsonPropertyName("isOverrideHomingRight_")]
    public bool IsOverrideHomingRight { get; set; } = false; // Offset 0xB7

    [JsonPropertyName("overrideHoming_")]
    public float OverrideHoming { get; set; } = 0.5f; // Offset 0xB8

    [JsonPropertyName("FrontAngle_")]
    public int FrontAngle { get; set; } = 45; // Offset 0xC0

    [JsonPropertyName("BuckAngle_")]
    public int BuckAngle { get; set; } = 45; // Offset 0xC4

    [JsonPropertyName("isOverrideAngle_")]
    public bool IsOverrideAngle { get; set; } = false; // Offset 0xBC

    public Em1800SpecifiedStepAction()
    {
    }
}
