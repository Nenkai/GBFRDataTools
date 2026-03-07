using GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Simulates an ability input from the player. 
    Requires an ability off cooldown to function. 
    
    Calls ability requested by AIBattleRequestAbilityAction. 'AbilitySlot' is defunct
    """)]
    
public class AIBattleAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAbilityAction);

    [JsonPropertyName("abilitySlot_")]
    [Description("Appears to be unused. No references in code as of 1.3.")]
    public int AbilitySlot { get; set; } = 0;

    [JsonPropertyName("isAllUseStack_")]
    [Description("Appears to be unused. No references in code as of 1.3.")]
    public bool IsAllUseStack { get; set; } = true;
}
