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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ZigzagRushAction : Em1700CircleThunderAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ZigzagRushAction);

    [JsonPropertyName("isCombo_")]
    public bool IsCombo { get; set; } = false; // Offset 0xA4

    [JsonPropertyName("isRight_")]
    public bool IsRight { get; set; } = true; // Offset 0xA5

    [JsonPropertyName("startSlipRate_")]
    public float StartSlipRate { get; set; } = 0.5f; // Offset 0xB0

    [JsonPropertyName("subSlipRate_")]
    public float SubSlipRate { get; set; } = 0.02f; // Offset 0xB4

    [JsonPropertyName("targetOffsetRot_")]
    public float TargetOffsetRot { get; set; } = 40f; // Offset 0xB8

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; // Offset 0xBC

    [JsonPropertyName("runAnimSpeed_")]
    public float RunAnimSpeed { get; set; } = 0.5f; // Offset 0xC0

    [JsonPropertyName("initHomingRate_")]
    public float InitHomingRate { get; set; } = 0.1f; // Offset 0xC4

    [JsonPropertyName("turnHomingRate_")]
    public float TurnHomingRate { get; set; } = 0.01f; // Offset 0xC8

    public Em1700ZigzagRushAction()
    {
    }
}
