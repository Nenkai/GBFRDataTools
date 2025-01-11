using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters;

public class Em7000Param : EmBossBaseParam
{
    [JsonPropertyName("rideSingleAttackMotionNameArray_")]
    public /* RideSingleAttackMotionNameArray */ BindingList<SideMotionName> RideSingleAttackMotionNameArray { get; set; } = []; // std::array<Em7000Param::SideMotionName,5>

    [JsonPropertyName("rideChangeMotionName_")]
    public SideMotionName RideChangeMotionName { get; set; }

    [JsonPropertyName("strikeAttackMotionNameArray_")]
    public BindingList<SideMotionName> StrikeAttackMotionNameArray { get; set; } = []; // std::array<Em7000Param::SideMotionName,2>

    [JsonPropertyName("attackParam_")]
    public BindingList<EmBossBaseParam.BossAttackParam> AttackParam { get; set; } = []; // std::array<EmBossBaseParam::BossAttackParam,2>

    [JsonPropertyName("strikeShockWaveLifeSecond_")]
    public float StrikeShockWaveLifeSecond { get; set; }

    [JsonPropertyName("energyBallParams_")]
    public Em7000EnergyBallParam EnergyBallParams { get; set; } // std::array<Em7000EnergyBallParam,5>

    [JsonPropertyName("shockWavePresagePosArray_")]
    public BindingList<Vector4> ShockWavePresagePosArray { get; set; } = []; // std::array<Hw::cVec4,4>

    [JsonPropertyName("attackComboPosArray_")]
    public BindingList<Vector4> AttackComboPosArray { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("lockOnArray_")]
    public BindingList<ActionLockOnParam> LockOnArray { get; set; } = []; // std::array<Em7000Param::ActionLockOnParam,19>

    [JsonPropertyName("cameraEnableArray_")]
    public /* EnableArray */ BindingList<bool> CameraEnableArray { get; set; } = []; // std::array<bool, 19>

    [JsonPropertyName("neckEnableArray_")]
    public /* EnableArray */ BindingList<bool> NeckEnableArray { get; set; } = []; // std::array<bool, 19>

    [JsonPropertyName("endLastPhaseBreak_")]
    public float EndLastPhaseBreak { get; set; }

    [JsonPropertyName("enableLockOnLength_")]
    public float EnableLockOnLength { get; set; }

    public class SideMotionName // Em7000Param::SideMotionName
    {
        [JsonPropertyName("left_")]
        public string Left { get; set; } // cyan::inplace_string<5>

        [JsonPropertyName("right_")]
        public string Right { get; set; } // cyan::inplace_string<5>
    }

    public class ActionLockOnParam // Em7000Param::ActionLockOnParam
    {
        [JsonPropertyName("isLockOn_")]
        public bool IsLockOn { get; set; }

        [JsonPropertyName("lockOnPartsNo_")]
        public int LockOnPartsNo { get; set; }
    }
}

public class Em7000EnergyBallParam
{
    [JsonPropertyName("bezierOffset_")]
    public /* cVec4 */ Vector4 BezierOffset { get; set; }

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; }

    [JsonPropertyName("setWaitSecondMax_")]
    public float SetWaitSecondMax { get; set; }

    [JsonPropertyName("moveSecond_")]
    public float MoveSecond { get; set; }

    [JsonPropertyName("attackSignOffsetDispSec_")]
    public float AttackSignOffsetDispSec { get; set; }

    [JsonPropertyName("setPos_")]
    public /* cVec4 */ Vector4 SetPos { get; set; }

    [JsonPropertyName("impactPos_")]
    public /* cVec4 */ Vector4 ImpactPos { get; set; }
}
