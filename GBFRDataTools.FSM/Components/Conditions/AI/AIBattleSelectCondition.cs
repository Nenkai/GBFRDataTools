using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class AIBattleSelectCondition : ConditionComponent
{
    [JsonPropertyName("comboIndex_")]
    public int ComboIndex { get; set; } = 0;

}
