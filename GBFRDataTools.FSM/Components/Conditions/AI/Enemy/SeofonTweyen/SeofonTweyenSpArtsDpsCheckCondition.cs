using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.SeofonTweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SeofonTweyenSpArtsDpsCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SeofonTweyenSpArtsDpsCheckCondition);

    [JsonPropertyName("dpsCheckTimer_")]
    public float DpsCheckTimer { get; set; } = 0f;

    [JsonPropertyName("dpsCheckComparaType_")]
    public SeofonTweyenSpArtsDpsCheckConditionCompareType DpsCheckComparaType { get; set; } = SeofonTweyenSpArtsDpsCheckConditionCompareType.LessThan;
}

public enum SeofonTweyenSpArtsDpsCheckConditionCompareType
{
    LessThan = 0,
    GreaterEqualTo = 1,
}