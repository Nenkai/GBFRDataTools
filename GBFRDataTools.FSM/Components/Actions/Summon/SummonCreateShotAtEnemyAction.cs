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
public class SummonCreateShotAtEnemyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCreateShotAtEnemyAction);

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfix_")]
    public string FsmInfix { get; set; }

    [JsonPropertyName("limit_")]
    public int Limit { get; set; } = 10;

    [JsonPropertyName("limitAngle_")]
    public float LimitAngle { get; set; } = 360f;

    [JsonPropertyName("limitLength_")]
    public float LimitLength { get; set; } = 0f;

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1f;

    [JsonPropertyName("isCheckLanding_")]
    public bool IsCheckLanding { get; set; } = false;

    [JsonPropertyName("sortType_")]
    public int SortType { get; set; } = 0;
}
