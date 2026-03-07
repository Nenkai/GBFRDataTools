using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0800_Seed;

public class EmSeedParam : EnemyParameterInfo
{
    [JsonPropertyName("hitCheckLength_")]
    public float HitCheckLength { get; set; }

    [JsonPropertyName("shotCoolTime_")]
    public float ShotCoolTime { get; set; }

    [JsonPropertyName("backStepCoolTime_")]
    public float BackStepCoolTime { get; set; }

    [JsonPropertyName("liftUpCollisionRadius_")]
    public float LiftUpCollisionRadius { get; set; }

    [JsonPropertyName("blowVecRate_")]
    public float BlowVecRate { get; set; }

    [JsonPropertyName("blowRotRate_")]
    public float BlowRotRate { get; set; }

    [JsonPropertyName("throwGravityRate_")]
    public float ThrowGravityRate { get; set; }

    [JsonPropertyName("blowBombAtkRate_")]
    public float BlowBombAtkRate { get; set; }

    [JsonPropertyName("blowBombBreakRate_")]
    public float BlowBombBreakRate { get; set; }

    [JsonPropertyName("blowBombHitStop_")]
    public int BlowBombHitStop { get; set; }

    [JsonPropertyName("blowBombAttackSignSize_")]
    public float BlowBombAttackSignSize { get; set; }

    public EmSeedParam()
    {
    }
}
