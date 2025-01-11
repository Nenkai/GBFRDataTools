using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class EmAttackWall_Param // EmAttackWall::Param
{
    [JsonPropertyName("moveEndDist_")]
    public float MoveEndDist { get; set; }

    [JsonPropertyName("EscapeDist")]
    public float EscapeDist { get; set; }

    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; }

    [JsonPropertyName("checkWallBackLength")]
    public float CheckWallBackLength { get; set; }

    [JsonPropertyName("frontArea_")]
    public float FrontArea { get; set; }

    [JsonPropertyName("frontAreaShortRangeOffset_")]
    public float FrontyAreaShortRangeOffset { get; set; }

    [JsonPropertyName("slowAreaRange_")]
    public float SlowAreaRange { get; set; }

    [JsonPropertyName("slowRate_")]
    public float SlowRate { get; set; }

    [JsonPropertyName("slowTime_")]
    public float SlowTime { get; set; }

    [JsonPropertyName("checkSlowAreaDist_")]
    public float IsWeakPoint { get; set; }

    [JsonPropertyName("checkEnemyNum")]
    public int CheckEnemyNum { get; set; }

    [JsonPropertyName("buffTime_")]
    public float BuffTime { get; set; }

    [JsonPropertyName("buffAttackRate_")]
    public float BuffAttackRate { get; set; }

    [JsonPropertyName("buffHealCycleSec_")]
    public float BuffHealCycleSec { get; set; }

    [JsonPropertyName("buffHealRate_")]
    public float BuffHealRate { get; set; }

    [JsonPropertyName("buffDist_")]
    public float BuffDist { get; set; }

    [JsonPropertyName("stepCoolTime_")]
    public float StepCoolTime { get; set; }

    [JsonPropertyName("trapCoolTime_")]
    public float TrapCoolTime { get; set; }

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; }

    [JsonPropertyName("firebBallHomingUpdateTime_")]
    public float FirebBallHomingUpdateTime { get; set; }

    [JsonPropertyName("fireWallParam_")]
    public EmAttackWall_Param FireWallParam { get; set; } // EmAttackWall::Param

    [JsonPropertyName("fireWallAtkRate_")]
    public float FireWallAtkRate { get; set; }

    [JsonPropertyName("fireWallBreakRate_")]
    public float FireWallBreakRate { get; set; }

    [JsonPropertyName("fireWallBurnSec_")]
    public float FireWallBurnSec { get; set; }

    [JsonPropertyName("fireWallBurnRate_")]
    public float FireWallBurnRate { get; set; }

    [JsonPropertyName("atkOntheSpotTypeList_")]
    public BindingList<int> DamageReactionBreakValue { get; set; } = []; // std::vector<int>
}
