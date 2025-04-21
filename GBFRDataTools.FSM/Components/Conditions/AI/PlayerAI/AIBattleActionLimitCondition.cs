using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

public class AIBattleActionLimitCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleActionLimitCondition);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;
}
