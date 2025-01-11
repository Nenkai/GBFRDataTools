using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class Em0200Param : EnemyParameterInfo
{
    [JsonPropertyName("dodgeInvisibleTime_")]
    public float DodgeInvisibleTime { get; set; }

    [JsonPropertyName("dodgePercent_")]
    public float DodgePercent { get; set; }

    [JsonPropertyName("backStepCoolTime_")]
    public float BackStepCoolTime { get; set; }

    [JsonPropertyName("dodgeCoolTime_")]
    public float DodgeCoolTime { get; set; }

    [JsonPropertyName("attackAfterDodgeCoolTime_")]
    public float AttackAfterDodgeCoolTime { get; set; }

    [JsonPropertyName("dashAttackCoolTime_")]
    public float DashAttackCoolTime { get; set; }

    [JsonPropertyName("dashSignGroundCheckHeight_")]
    public float DashSignGroundCheckHeight { get; set; }

    [JsonPropertyName("tutorialCombatPower_")]
    public int TutorialCombatPower { get; set; }

    [JsonPropertyName("riderDoubleRushCoolTime_")]
    public float RiderDoubleRushCoolTime { get; set; }

    [JsonPropertyName("noAttackHpPercent_")]
    public int NoAttackHpPercent { get; set; }

    [JsonPropertyName("riderUiOffsetY_")]
    public float RiderUiOffsetY { get; set; }
}
