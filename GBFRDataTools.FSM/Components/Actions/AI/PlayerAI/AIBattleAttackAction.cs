using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param.AIParam;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Simulates an input from the player for the purpose of attacking
    Summary: AttackType + Timer + (Is Charge or IsRapid)
    """)]
public class AIBattleAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAttackAction);

    [JsonPropertyName("attackType_")]
    public AIBattleAttackActionAttackType AttackType { get; set; } = AIBattleAttackActionAttackType.X;

    [Description("""
        Interval in seconds that this action is active for. 
        Once timer finishes, ActionEndCondition will return true. Timer is active regardless of IsCharge or IsRapid states.
        """)]
    [JsonPropertyName("timer_")]
    public float Timer { get; set; } = 0.0f;

    [Description("""
        For actions that support variable charge times, will hold the charge until the timer ends. 
        Certain actions force full charge behavior regardless of if this variable is true.
        """)]
    [JsonPropertyName("isCharge_")]
    public bool IsCharge { get; set; } = false;

    [Description("""
        Simulates pressing the AttackType selected at the frame interval specified in RapidIntervalFrame for the timer duration
        """)]
    [JsonPropertyName("isRapid_")]
    public bool IsRapid { get; set; } = false;

    [JsonPropertyName("rapidIntervalFrame_")]
    public int RapidIntervalFrame { get; set; } = 0;

    public override string GetCaption()
    {
        string str = $"{Utils.GetEnumDescription(AttackType)} ({Timer}s)";
        if (IsCharge)
            str += " (Charged)";
        return str;
    }
}

