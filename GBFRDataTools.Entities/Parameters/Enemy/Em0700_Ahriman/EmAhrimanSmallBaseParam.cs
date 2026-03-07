using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0700_Ahriman;

public class EmAhrimanSmallBaseParam : EnemyParameterInfo
{
    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; }

    [JsonPropertyName("baseHeight_")]
    public float BaseHeight { get; set; }

    [JsonPropertyName("populationHeightAdd_")]
    public float PopulationHeightAdd { get; set; }

    [JsonPropertyName("lowHeight_")]
    public float LowHeight { get; set; }

    [JsonPropertyName("targetHeightMaxDiff_")]
    public float TargetHeightMaxDiff { get; set; }

    [JsonPropertyName("attackCoolTime_")]
    public float AttackCoolTime { get; set; }

    [JsonPropertyName("stepCoolTime_")]
    public float StepCoolTime { get; set; }

    [JsonPropertyName("aroundTheBackCoolTime_")]
    public float AroundTheBackCoolTime { get; set; }

    [JsonPropertyName("frontChargeCoolTime_")]
    public float FrontChargeCoolTime { get; set; }

    [JsonPropertyName("checkWallLength_")]
    public float CheckWallLength { get; set; }

    [JsonPropertyName("frontArea_")]
    public float FrontArea { get; set; }

    [JsonPropertyName("frontAreaShortRangeOffset_")]
    public float FrontAreaShortRangeOffset { get; set; }

    [JsonPropertyName("hitEyePosOffset_")]
    public Vector4 HitEyePosOffset { get; set; }

    [JsonPropertyName("hitEyeAreaDeg_")]
    public float HitEyeAreaDeg { get; set; }

    [JsonPropertyName("frontChargeTime_")]
    public float FrontChargeTime { get; set; }

    [JsonPropertyName("frontChargeShotDelayTime_")]
    public float FrontChargeShotDelayTime { get; set; }

    [JsonPropertyName("targetShotArea_Short_")]
    public Vector2 TargetShotArea_Short { get; set; }

    [JsonPropertyName("targetShotArea_Middle_")]
    public Vector2 TargetShotArea_Middle { get; set; }

    [JsonPropertyName("targetShotArea_Long_")]
    public Vector2 TargetShotArea_Long { get; set; }

    [JsonPropertyName("frontChargeStartPosOffset_")]
    public Vector4 FrontChargeStartPosOffset { get; set; }

    [JsonPropertyName("debugFullChargeSize_")]
    public float DebugFullChargeSize { get; set; }

    [JsonPropertyName("debugFrontShotSizeRatio_")]
    public float DebugFrontShotSizeRatio { get; set; }

    [JsonPropertyName("laserNum_")]
    public int LaserNum { get; set; }

    [JsonPropertyName("laserFrontChargeParam_")]
    public EmAhrimanBaseLaserParam LaserFrontChargeParam { get; set; }

    [JsonPropertyName("laserTauntSwingParam_")]
    public EmAhrimanBaseLaserParam LaserTauntSwingParam { get; set; }

    [JsonPropertyName("omenControlHeight_")]
    public float OmenControlHeight { get; set; }

    [JsonPropertyName("rockShotOffset_")]
    public Vector4 RockShotOffset { get; set; }

    [JsonPropertyName("rockShotFsmClassName_")]
    public string RockShotFsmClassName { get; set; }

    [JsonPropertyName("rockShotFsmFileName_")]
    public string RockShotFsmFileName { get; set; }

    [JsonPropertyName("rockShotGroundVfxEstId_")]
    public int RockShotGroundVfxEstId { get; set; }

    [JsonPropertyName("damageReactionGauge_")]
    public EmDamageReactionGaugeParam DamageReactionGauge { get; set; }

    [JsonPropertyName("heavyDamageReactionScale_")]
    public float HeavyDamageReactionScale { get; set; }

    [JsonPropertyName("scaleParam_")]
    public float ScaleParam { get; set; }

    [JsonPropertyName("stageHitColScale_")]
    public float StageHitColScale { get; set; }

    [JsonPropertyName("stageHitColOffset_")]
    public Vector4 StageHitColOffset { get; set; }

    [JsonPropertyName("groundCheckEndHeight_")]
    public float GroundCheckEndHeight { get; set; }

    [JsonPropertyName("isDeadSmallEffect_")]
    public bool IsDeadSmallEffect { get; set; }

    public EmAhrimanSmallBaseParam()
    {
    }
}
