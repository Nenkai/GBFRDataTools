using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonEnemyDirectionCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonEnemyDirectionCheckCondition);

    [JsonPropertyName("targetRangeType_")]
    public int TargetRangeType { get; set; } = 0;

    [JsonPropertyName("checkDirDegree_")]
    public float CheckDirDegree { get; set; } = 0f;

    [JsonPropertyName("checkShortestDegree_")]
    public float CheckShortestDegree { get; set; } = 0f;
}
