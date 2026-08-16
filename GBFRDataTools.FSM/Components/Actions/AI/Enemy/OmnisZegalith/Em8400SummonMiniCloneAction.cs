using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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
public class Em8400SummonMiniCloneAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400SummonMiniCloneAction);

    [JsonPropertyName("summonStartDelayTimeSec_")]
    public float SummonStartDelayTimeSec { get; set; } = 1f;

    [JsonPropertyName("actionEndDelayTimeSec_")]
    public float ActionEndDelayTimeSec { get; set; } = 1.5f;

    [JsonPropertyName("miniClonePhase_")]
    public int MiniClonePhase { get; set; } = 0;

    [JsonPropertyName("isUseReturnMotion_")]
    public bool IsUseReturnMotion { get; set; } = false;

    [JsonPropertyName("lastSummonDelayFrame_")]
    public int LastSummonDelayFrame { get; set; } = 50;
}