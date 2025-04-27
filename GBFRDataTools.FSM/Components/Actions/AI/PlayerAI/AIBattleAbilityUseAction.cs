using GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleAbilityUseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAbilityUseAction);

    [JsonPropertyName("abilityTag_")]
    public string AbilityTag { get; set; } // Offset 0x30

    public AIBattleAbilityUseAction()
    {
    }
}
