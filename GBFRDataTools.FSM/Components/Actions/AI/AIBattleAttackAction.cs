using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AIBattleAttackAction : ActionComponent
{
    [JsonPropertyName("attackType_")]
    public AttackTypeEnum AttackType { get; set; }

    [JsonPropertyName("timer_")]
    public float Timer { get; set; }

    [JsonPropertyName("isCharge_")]
    public bool IsCharge { get; set; }

    [JsonPropertyName("isRapid_")]
    public bool IsRapid { get; set; }

    [JsonPropertyName("rapidIntervalFrame_")]
    public int RapidIntervalFrame { get; set; }

    public enum AttackTypeEnum
    {
        AttackType0 = 0,
        AttackType1 = 1,
        AttackType2 = 2,
    }
}

