using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Motion;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7201ExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201ExAttackAction);

    [JsonPropertyName("stageBaseMoveSpd_")]
    public float StageBaseMoveSpd { get; set; } = 15f;

    [JsonPropertyName("innerRadius_")]
    public float InnerRadius { get; set; } = 5f;

    [JsonPropertyName("secondSignMoveTime_")]
    public float SecondSignMoveTime { get; set; } = 3f;

    [JsonPropertyName("secondSignWaitTime_")]
    public float SecondSignWaitTime { get; set; } = 1f;

    [JsonPropertyName("secondAttackTime_")]
    public float SecondAttackTime { get; set; } = 2f;

    [JsonPropertyName("inhaleSpeedFirst_")]
    public float InhaleSpeedFirst { get; set; } = 2.5f;

    [JsonPropertyName("inhaleSpeedSecond_")]
    public float InhaleSpeedSecond { get; set; } = 5.5f;

    [JsonPropertyName("inhaleCorrectRateFirst_")]
    public float InhaleCorrectRateFirst { get; set; } = 0.2f;

    [JsonPropertyName("inhaleCorrectRateSecond_")]
    public float InhaleCorrectRateSecond { get; set; } = 0.05f;
}