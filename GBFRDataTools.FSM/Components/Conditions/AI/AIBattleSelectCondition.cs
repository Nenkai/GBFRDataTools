using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

[Description("Returns whether the value decided by AIBattleSelectComboAction matches value specified")]
public class AIBattleSelectCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleSelectCondition);

    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0;

}
