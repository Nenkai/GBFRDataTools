using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0900_Statue;

public class EmStatueBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("scaleParam_")]
    public float ScaleParam { get; set; }

    [JsonPropertyName("damageReactionBreakValue_")]
    public float DamageReactionBreakValue { get; set; }

    [JsonPropertyName("coreLightOffSec_")]
    public float CoreLightOffSec { get; set; }

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; }

    [JsonPropertyName("stepCoolTime_")]
    public float StepCoolTime { get; set; }

    [JsonPropertyName("coreLightUpGuardRate_")]
    public float CoreLightUpGuardRate { get; set; }

    [JsonPropertyName("coreLightUpGuardBreakRate_")]
    public float CoreLightUpGuardBreakRate { get; set; }

    [JsonPropertyName("coreLightUpKnockBackRate_")]
    public float CoreLightUpKnockBackRate { get; set; }

    [JsonPropertyName("coreLightUpCounterRate_")]
    public float CoreLightUpCounterRate { get; set; }

    [JsonPropertyName("coreLightUpGuardUi_")]
    public bool CoreLightUpGuardUi { get; set; }

    [JsonPropertyName("coreLightUpGuardEffect_")]
    public bool CoreLightUpGuardEffect { get; set; }

    [JsonPropertyName("coreLightUpGuardSe_")]
    public bool CoreLightUpGuardSe { get; set; }

    [JsonPropertyName("coreLightAlphaRate_")]
    public float CoreLightAlphaRate { get; set; }

    [JsonPropertyName("coreLightOnEmissiveRate_")]
    public float CoreLightOnEmissiveRate { get; set; }

    [JsonPropertyName("coreLightOffEmissiveRate_")]
    public float CoreLightOffEmissiveRate { get; set; }

    [JsonPropertyName("drillFlyMoveStopRangeXZ_")]
    public float DrillFlyMoveStopRangeXZ { get; set; }

    [JsonPropertyName("drillFlyMoveSpdXZ_")]
    public float DrillFlyMoveSpdXZ { get; set; }

    public EmStatueBaseParam()
    {
    }
}
