using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAttackAction);

    [JsonPropertyName("attackType_")]
    public AIBattleAttackActionAttackType AttackType { get; set; } = AIBattleAttackActionAttackType.X;

    [JsonPropertyName("timer_")]
    public float Timer { get; set; } = 0.0f;

    [JsonPropertyName("isCharge_")]
    public bool IsCharge { get; set; } = false;

    [JsonPropertyName("isRapid_")]
    public bool IsRapid { get; set; } = false;

    [Description("Added in Endless Ragnarok.")]
    [JsonPropertyName("isCallRelease_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsCallRelease { get; set; } = false; 

    [JsonPropertyName("isHold_")]
    [Description("Added in Endless Ragnarok.")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsHold { get; set; } = false; 

    [JsonPropertyName("rapidIntervalFrame_")]
    public int RapidIntervalFrame { get; set; } = 0;

    public override string? GetCaption()
    {
        string str = $"{Utils.GetEnumDescription(AttackType)} ({Timer}s)";
        if (IsCharge)
            str += " (Charged)";
        return str;
    }
}

