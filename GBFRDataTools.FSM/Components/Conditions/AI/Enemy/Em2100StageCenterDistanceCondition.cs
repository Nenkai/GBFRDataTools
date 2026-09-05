using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2100StageCenterDistanceCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100StageCenterDistanceCondition);

    [JsonPropertyName("operator_")]
    public int Operator { get; set; } = 0;

    [JsonPropertyName("distance_")]
    public float Distance { get; set; } = 0f;
}