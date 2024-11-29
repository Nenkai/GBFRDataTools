using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleUseIdAction : ActionComponent
{
    [JsonPropertyName("setActionId_")]
    public int SetActionId { get; set; } = 0;

    [JsonPropertyName("buttonSlot_")]
    public int ButtonSlot { get; set; } = 0;

    [JsonPropertyName("isUseAbility_")]
    public bool IsUseAbility { get; set; } = false;

    [JsonPropertyName("isCheckDist_")]
    public bool IsCheckDist { get; set; } = false;

    [JsonPropertyName("isAllStackUse_")]
    public bool IsAllStackUse { get; set; } = false;

    [JsonPropertyName("isAllChargeUse_")]
    public bool IsAllChargeUse { get; set; } = false;

    [JsonPropertyName("abilityFlagBit_")]
    public uint AbilityFlagBit { get; set; } = 0;
}
