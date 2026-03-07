using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

[Description("Returns whether if the current AI matches the party slot specified in 'Index'.")]
public class AIBattleIndexCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleIndexCondition);

    [JsonPropertyName("index_")]
    public int Index { get; set; } = 0;
}
