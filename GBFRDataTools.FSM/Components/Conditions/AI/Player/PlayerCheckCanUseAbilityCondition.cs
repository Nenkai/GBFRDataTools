using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class PlayerCheckCanUseAbilityCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerCheckCanUseAbilityCondition);

    [JsonPropertyName("abilityFlagBit_")]
    public uint AbilityFlagBit { get; set; } = 0;

    [JsonPropertyName("isCheckSuccessUseIdAction_")]
    public bool IsCheckSuccessUseIdAction { get; set; } = false;
}
