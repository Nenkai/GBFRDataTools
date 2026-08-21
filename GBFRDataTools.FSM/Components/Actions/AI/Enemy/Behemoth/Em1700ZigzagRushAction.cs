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
    public bool IsCombo { get; set; } = false; 

    [JsonPropertyName("isRight_")]
    public bool IsRight { get; set; } = true; 

    [JsonPropertyName("startSlipRate_")]
    public float StartSlipRate { get; set; } = 0.5f; 

    [JsonPropertyName("subSlipRate_")]
    public float SubSlipRate { get; set; } = 0.02f; 

    [JsonPropertyName("targetOffsetRot_")]
    public float TargetOffsetRot { get; set; } = 40f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.1f; 

    [JsonPropertyName("runAnimSpeed_")]
    public float RunAnimSpeed { get; set; } = 0.5f; 

    [JsonPropertyName("initHomingRate_")]
    public float InitHomingRate { get; set; } = 0.1f; 

    [JsonPropertyName("turnHomingRate_")]
    public float TurnHomingRate { get; set; } = 0.01f;
}
