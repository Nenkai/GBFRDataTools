using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class AIBattleSequenceCondition : ConditionComponent
{
    [JsonPropertyName("flagType_")]
    public AIBattleSequenceConditionFlagType FlagType { get; set; } = AIBattleSequenceConditionFlagType.Type0;
}

public enum AIBattleSequenceConditionFlagType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
}
