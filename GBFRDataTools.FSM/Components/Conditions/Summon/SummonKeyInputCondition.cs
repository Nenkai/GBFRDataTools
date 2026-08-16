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
public class SummonKeyInputCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonKeyInputCondition);

    [JsonPropertyName("button_")]
    public int Button { get; set; } = 0;

    [JsonPropertyName("isHoldCheck_")]
    public bool IsHoldCheck { get; set; } = false;
}
