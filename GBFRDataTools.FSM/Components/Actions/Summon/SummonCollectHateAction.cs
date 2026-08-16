using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonCollectHateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCollectHateAction);

    [JsonPropertyName("targetRange_")]
    public float TargetRange { get; set; } = 30f;

    [JsonPropertyName("isResetHateOnEnd_")]
    public bool IsResetHateOnEnd { get; set; } = true;

    [JsonPropertyName("isResetHateOnStart_")]
    public bool IsResetHateOnStart { get; set; } = false;

    [JsonPropertyName("hateSignSec_")]
    public float HateSignSec { get; set; } = 10f;
}
