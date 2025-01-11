using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class Em0000Param : EnemyParameterInfo
{
    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; }

    [JsonPropertyName("slashAttackCoolTime_")]
    public float SlashAttackCoolTime { get; set; }

    [JsonPropertyName("jumpAttackCoolTime_")]
    public float JumpAttackCoolTime { get; set; }

    [JsonPropertyName("backMoveCoolTime_")]
    public float BackMoveCoolTime { get; set; }

    [JsonPropertyName("menacingCoolTime_")]
    public float MenacingCoolTime { get; set; }

    [JsonPropertyName("defaultAttackHomingRate_")]
    public float DefaultAttackHomingRate { get; set; }

    [JsonPropertyName("defaultAttackHomingMaxAngle_")]
    public float DefaultAttackHomingMaxAngle { get; set; }

    [JsonPropertyName("defaultMoveToFormOffset_")]
    public float DefaultMoveToFormOffset { get; set; }

    [JsonPropertyName("defaultMoveToMaxDist_")]
    public float DefaultMoveToMaxDist { get; set; }

    [JsonPropertyName("clearRiderCheckHpRate_")]
    public float ClearRiderCheckHpRate { get; set; }

    [JsonPropertyName("clearRiderCounterCheckDamageRate_")]
    public float ClearRiderCounterCheckDamageRate { get; set; }
}
