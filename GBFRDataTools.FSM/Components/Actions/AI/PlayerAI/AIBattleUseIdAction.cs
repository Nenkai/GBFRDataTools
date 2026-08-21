using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Player;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param.AIParam;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleUseIdAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleUseIdAction);

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
    public ActionCategory AbilityFlagBit { get; set; } = 0;

    [JsonPropertyName("isCheckOnlySetAction_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsCheckOnlySetAction { get; set; } = false;

    public override string? GetCaption()
    {
        return $"ActionId: {SetActionId}, ButtonSlot: {ButtonSlot}";
    }
}
