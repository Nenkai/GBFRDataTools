using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl2300Param : PlayerParameterInfo
{
    [JsonPropertyName("isMultiLockLongInputBranch_")]
    public bool IsMultiLockLongInputBranch { get; set; }

    [JsonPropertyName("isViewDebugGauge_")]
    public bool IsViewDebugGauge { get; set; }

    [JsonPropertyName("normalShotMoveSpeed_")]
    public float NormalShotMoveSpeed { get; set; }

    [JsonPropertyName("normalShotBlendInterRate_")]
    public float NormalShotBlendInterRate { get; set; }

    [JsonPropertyName("airPowerShotRotX_")]
    public float AirPowerShotRotX { get; set; }

    [JsonPropertyName("stackPointArray_")]
    public BindingList<float> StackPointArray { get; set; } = []; // std::array<float,27>

    [JsonPropertyName("aimCameraRate_")]
    public float AimCameraRate { get; set; }

    [JsonPropertyName("aimCameraSpeed_")]
    public float AimCameraSpeed { get; set; }

    [JsonPropertyName("multiLockAddIntervalSec_")]
    public float MultiLockAddIntervalSec { get; set; }

    [JsonPropertyName("multiLockShotIntervalFrame_")]
    public float MultiLockShotIntervalFrame { get; set; }

    [JsonPropertyName("multiLockMeleeModeDist_")]
    public float MultiLockMeleeModeDist { get; set; }

    [JsonPropertyName("multiLockLv2Line_")]
    public int MultiLockLv2Line { get; set; }

    [JsonPropertyName("multiLockLv3Line_")]
    public int MultiLockLv3Line { get; set; }

    [JsonPropertyName("depravityDebuffShotMaxNum_")]
    public int DepravityDebuffShotMaxNum { get; set; }

    [JsonPropertyName("depravityShotIntervalFrame_")]
    public float DepravityShotIntervalFrame { get; set; }

    [JsonPropertyName("clincherAtkBonusParamArray_")]
    public BindingList<float> ClincherAtkBonusParamArray { get; set; } = []; // std::array<float,8>

    [JsonPropertyName("spinUpperShotStartOffset_")]
    public /* cVec4 */ Vector4 SpinUpperShotStartOffset { get; set; }

    [JsonPropertyName("spinUpperShotStartRotY_")]
    public float SpinUpperShotStartRotY { get; set; }

    [JsonPropertyName("spinUpperShotAddRotValue_")]
    public float SpinUpperShotAddRotValue { get; set; }

    [JsonPropertyName("spinUpperShotIntervalFrame_")]
    public float SpinUpperShotIntervalFrame { get; set; }

    [JsonPropertyName("spinUpperShotOnceShotNum_")]
    public int SpinUpperShotOnceShotNum { get; set; }

    [JsonPropertyName("arrowRainCallSeDelaySec_")]
    public float ArrowRainCallSeDelaySec { get; set; }

    [JsonPropertyName("arrowRainCallSeSec_")]
    public float ArrowRainCallSeSec { get; set; }

    [JsonPropertyName("avoidAbilityUseRangeByAI_")]
    public float AvoidAbilityUseRangeByAI { get; set; }

    [JsonPropertyName("walkShotTargetSelectParam_")]
    public PlayerLockOnParameter WalkShotTargetSelectParam { get; set; }
}
