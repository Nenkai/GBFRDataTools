using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleAbilityAction : ActionComponent
{
    [JsonPropertyName("abilitySlot_")]
    public int AbilitySlot { get; set; }

    [JsonPropertyName("isAllUseStack_")]
    public bool IsAllUseStack { get; set; }
}
