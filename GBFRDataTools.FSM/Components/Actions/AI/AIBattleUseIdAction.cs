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
    public int SetActionId { get; set; }

    [JsonPropertyName("buttonSlot_")]
    public int ButtonSlot { get; set; }

    [JsonPropertyName("isUseAbility_")]
    public bool IsUseAbility { get; set; }

    [JsonPropertyName("isCheckDist_")]
    public bool IsCheckDist { get; set; }

    [JsonPropertyName("isAllStackUse_")]
    public bool IsAllStackUse { get; set; }

    [JsonPropertyName("isAllChargeUse_")]
    public bool IsAllChargeUse { get; set; }

    [JsonPropertyName("abilityFlagBit_")]
    public uint AbilityFlagBit { get; set; }
}
