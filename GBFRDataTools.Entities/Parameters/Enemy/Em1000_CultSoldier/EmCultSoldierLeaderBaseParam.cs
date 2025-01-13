using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em1000_CultSoldier;

public class EmCultSoldierLeaderBaseParam : EmCultSoldierBaseParam
{
    [JsonPropertyName("leaderBuffTime_")]
    public float LeaderBuffTime { get; set; }

    [JsonPropertyName("leaderBuffCoolTime_")]
    public float LeaderBuffCoolTime { get; set; }

    [JsonPropertyName("leaderBuffMaxSoldiers_")]
    public int LeaderBuffMaxSoldiers { get; set; }

    [JsonPropertyName("leaderAttackStartSoldiers_")]
    public int LeaderAttackStartSoldiers { get; set; }

    [JsonPropertyName("leaderBuffRadius_")]
    public float LeaderBuffRadius { get; set; }

    [JsonPropertyName("leaderBuffRequireSoldiers_")]
    public int LeaderBuffRequireSoldiers { get; set; }

    public EmCultSoldierLeaderBaseParam()
    {
    }
}