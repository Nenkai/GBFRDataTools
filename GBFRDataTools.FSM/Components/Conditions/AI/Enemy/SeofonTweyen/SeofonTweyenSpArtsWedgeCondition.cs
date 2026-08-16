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
public class SeofonTweyenSpArtsWedgeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SeofonTweyenSpArtsWedgeCondition);

    [JsonPropertyName("isBigWedgeOnly_")]
    public bool IsBigWedgeOnly { get; set; } = true;
}