using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceBattleCondition : ConditionComponent
{
    [JsonPropertyName("isCheckID_")]
    public bool IsCheckID { get; set; } = false;

    [JsonPropertyName("enemyID_")]
    public int EnemyID { get; set; } = 0;
}
