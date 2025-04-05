using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Performs an action by ID. Can also perform abilities by flagbits.
    Checks for abilities equipped and requires them to be off cooldown.
    Does not simulate player inputs, will force stop previous action to call current action.
    """)]
public class AIBattleUseIdAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleUseIdAction);

    [JsonPropertyName("setActionId_")]
    public int SetActionId { get; set; } = 0;

    [JsonPropertyName("buttonSlot_")]
    public int ButtonSlot { get; set; } = 0;

    [JsonPropertyName("isUseAbility_")]
    [Description("Enables AbilityFlagBit (abilityFlagBit_).")]
    public bool IsUseAbility { get; set; } = false;

    [JsonPropertyName("isCheckDist_")]
    [Description("References \"dist_\" in the data for the action found in the character's action file.")]
    public bool IsCheckDist { get; set; } = false;

    [JsonPropertyName("isAllStackUse_")]
    [Description("Uses all stacks/charges of the ability.")]
    public bool IsAllStackUse { get; set; } = false;

    [JsonPropertyName("isAllChargeUse_")]
    [Description("Uses the ability for the longest period possible if the ability allows held inputs.")]
    public bool IsAllChargeUse { get; set; } = false;

    [JsonPropertyName("abilityFlagBit_")]
    [Description("Refers to ActionInfo -> actionCategory_ in player action files.")]
    public AbilityActionCategoryBit AbilityFlagBit { get; set; } = 0;
}
