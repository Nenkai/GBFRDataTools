using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class AIBattleObjectAliveCondition : ConditionComponent
{
    [JsonPropertyName("type_")]
    public AIBattleObjectAliveConditionType Type { get; set; }
}

public enum AIBattleObjectAliveConditionType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2
}