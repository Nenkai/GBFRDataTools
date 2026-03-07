using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Player;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Requests an ability by flagbit.
    AIBattleAbilityAction will perform the ability prepared by this action when called.
    """)]
public class AIBattleRequestAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleRequestAbilityAction);

    [JsonPropertyName("abilityFlagBit_")]
    [Description("Refers to ActionInfo -> actionCategory_ in player action files.")]
    public ActionCategory AbilityFlagBit { get; set; } = 0;
}
