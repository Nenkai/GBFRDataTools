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
public class SummonLinkPointAboveOrBelowCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonLinkPointAboveOrBelowCheckCondition);

    [JsonPropertyName("checkValue_")]
    public float CheckValue { get; set; } = 0f;

    [JsonPropertyName("checkAbove_")]
    public bool CheckAbove { get; set; } = false;
}
