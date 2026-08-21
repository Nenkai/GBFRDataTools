using GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAbilityAction);

    [JsonPropertyName("abilitySlot_")]
    public int AbilitySlot { get; set; } = 0;

    [JsonPropertyName("isAllUseStack_")]
    public bool IsAllUseStack { get; set; } = true;

    public override string? GetCaption()
    {
        return $"AbilitySlot: {AbilitySlot} (IsAllUseStack: {IsAllUseStack})";
    }
}
