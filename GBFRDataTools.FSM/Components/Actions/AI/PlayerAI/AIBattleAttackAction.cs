using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Simulates an input from the player for the purpose of attacking")]
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

    [JsonPropertyName("rapidIntervalFrame_")]
    public int RapidIntervalFrame { get; set; } = 0;
}

