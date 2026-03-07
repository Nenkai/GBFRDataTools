using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.PlayerAI;

[Description("Returns whether specific motion flags are active for an AI")]
public class AIBattleSequenceCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleSequenceCondition);

    [JsonPropertyName("flagType_")]
    public AIBattleSequenceConditionFlagType FlagType { get; set; } = AIBattleSequenceConditionFlagType.XY;
}
