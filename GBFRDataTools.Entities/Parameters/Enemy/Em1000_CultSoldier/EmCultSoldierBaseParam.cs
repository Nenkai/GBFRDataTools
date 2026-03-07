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

public class EmCultSoldierBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("counterAttackProbability_")]
    public int CounterAttackProbability { get; set; }

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("maxFormationSoldiers_")]
    public int MaxFormationSoldiers { get; set; }

    [JsonPropertyName("maxFormationDeg_")]
    public float MaxFormationDeg { get; set; }

    [JsonPropertyName("minFormationDeg_")]
    public float MinFormationDeg { get; set; }

    [JsonPropertyName("insideCameraDeg_")]
    public float InsideCameraDeg { get; set; }

    [JsonPropertyName("insideCameraOffsetY_")]
    public float InsideCameraOffsetY { get; set; }

    [JsonPropertyName("insideCameraRadius_")]
    public float InsideCameraRadius { get; set; }

    [JsonPropertyName("insideCameraCoolTime_")]
    public float InsideCameraCoolTime { get; set; }

    [JsonPropertyName("drainRate_")]
    public float DrainRate { get; set; }

    public EmCultSoldierBaseParam()
    {
    }
}