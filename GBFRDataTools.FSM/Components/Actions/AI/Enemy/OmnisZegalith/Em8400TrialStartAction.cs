using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400TrialStartAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400TrialStartAction);

    [JsonPropertyName("actionEndWaitTime_")]
    public float ActionEndWaitTime { get; set; } = 3f;

    [JsonPropertyName("motionInterRate_")]
    public float MotionInterRate { get; set; } = 0.5f;

    [JsonPropertyName("trialType_")]
    public int TrialType { get; set; } = 0;

    [JsonPropertyName("trialTimeLimit_")]
    public float TrialTimeLimit { get; set; } = 60f;

    [JsonPropertyName("trialClearHpPercent_")]
    public float TrialClearHpPercent { get; set; } = 3f;
}
