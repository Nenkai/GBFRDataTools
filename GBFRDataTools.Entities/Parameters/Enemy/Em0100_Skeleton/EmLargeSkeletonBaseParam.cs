using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0100_Skeleton;

public class EmLargeSkeletonBaseParam : EmBossBaseParam
{
    [JsonPropertyName("summonNum_LevelAi1_")]
    public int SummonNum_LevelAi1 { get; set; }

    [JsonPropertyName("summonNum_LevelAi2_")]
    public int SummonNum_LevelAi2 { get; set; }

    [JsonPropertyName("summonNum_LevelAi3_")]
    public int SummonNum_LevelAi3 { get; set; }

    [JsonPropertyName("summonNum_LevelAi4_")]
    public int SummonNum_LevelAi4 { get; set; }

    [JsonPropertyName("summonCoolSec_LevelAi1_")]
    public float SummonCoolSec_LevelAi1 { get; set; }

    [JsonPropertyName("summonCoolSec_LevelAi2_")]
    public float SummonCoolSec_LevelAi2 { get; set; }

    [JsonPropertyName("summonCoolSec_LevelAi3_")]
    public float SummonCoolSec_LevelAi3 { get; set; }

    [JsonPropertyName("summonCoolSec_LevelAi4_")]
    public float SummonCoolSec_LevelAi4 { get; set; }

    [JsonPropertyName("throwSummonNum_")]
    public int ThrowSummonNum { get; set; }

    [JsonPropertyName("warpTargetWaitSec_")]
    public float WarpTargetWaitSec { get; set; }

    [JsonPropertyName("warpTargetBindSec_")]
    public float WarpTargetBindSec { get; set; }

    [JsonPropertyName("warpTargetSignSec_LowLevelAi_")]
    public float WarpTargetSignSec_LowLevelAi { get; set; }

    [JsonPropertyName("warpTargetSignSec_HighLevelAi_")]
    public float WarpTargetSignSec_HighLevelAi { get; set; }

    [JsonPropertyName("warpTargetOffsetLength_")]
    public float WarpTargetOffsetLength { get; set; }

    [JsonPropertyName("slashShotSpeed_LowLevelAi_")]
    public float SlashShotSpeed_LowLevelAi { get; set; }

    [JsonPropertyName("slashShotSpeed_HighLevelAi_")]
    public float SlashShotSpeed_HighLevelAi { get; set; }

    [JsonPropertyName("odAbilityCoolTimeSec_")]
    public float OdAbilityCoolTimeSec { get; set; }

    [JsonPropertyName("odAbilitySummonCount_LowLevelAi_")]
    public int OdAbilitySummonCount_LowLevelAi { get; set; }

    [JsonPropertyName("odAbilitySummonCount_HighLevelAi_")]
    public int OdAbilitySummonCount_HighLevelAi { get; set; }

    [JsonPropertyName("odAbilitySummonWaitSec_LowLevelAi_")]
    public float OdAbilitySummonWaitSec_LowLevelAi { get; set; }

    [JsonPropertyName("odAbilitySummonWaitSec_HighLevelAi_")]
    public float OdAbilitySummonWaitSec_HighLevelAi { get; set; }

    [JsonPropertyName("odAbilityWaveSpreadSec_LowLevelAi_")]
    public float OdAbilityWaveSpreadSec_LowLevelAi { get; set; }

    [JsonPropertyName("odAbilityWaveSpreadSec_HighLevelAi_")]
    public float OdAbilityWaveSpreadSec_HighLevelAi { get; set; }

    [JsonPropertyName("odAbilityWaveWaitSec_LowLevelAi_")]
    public float OdAbilityWaveWaitSec_LowLevelAi { get; set; }

    [JsonPropertyName("odAbilityWaveWaitSec_HighLevelAi_")]
    public float OdAbilityWaveWaitSec_HighLevelAi { get; set; }

    [JsonPropertyName("odAbilitySummonRadius_")]
    public float OdAbilitySummonRadius { get; set; }

    [JsonPropertyName("odAbilityWaveRadius_")]
    public float OdAbilityWaveRadius { get; set; }

    [JsonPropertyName("attackModeSec_LevelAi1_")]
    public float AttackModeSec_LevelAi1 { get; set; }

    [JsonPropertyName("attackModeCoolSec_LevelAi1_")]
    public float AttackModeCoolSec_LevelAi1 { get; set; }

    [JsonPropertyName("odAbilityWaveAttackRate_")]
    public float OdAbilityWaveAttackRate { get; set; }

    [JsonPropertyName("slashShotAttackRate_")]
    public float SlashShotAttackRate { get; set; }

    [JsonPropertyName("odAbilityWaveBreakRate_")]
    public float OdAbilityWaveBreakRate { get; set; }

    [JsonPropertyName("slashShotBreakRate_")]
    public float SlashShotBreakRate { get; set; }

    [JsonPropertyName("counterSlowRate_LowLevelAi_")]
    public float CounterSlowRate_LowLevelAi { get; set; }

    [JsonPropertyName("counterSlowRate_HighLevelAi_")]
    public float CounterSlowRate_HighLevelAi { get; set; }

    public EmLargeSkeletonBaseParam()
    {
    }
}
