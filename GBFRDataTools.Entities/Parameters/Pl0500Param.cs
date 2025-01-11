using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0500Param : PlayerParameterInfo
{
    [JsonPropertyName("useParamNum")]
    public int UseParamNum { get; set; }

    [JsonPropertyName("bombStickyParam_")]
    public BindingList<BombStickyParam> BombStickyParam_ { get; set; } = []; // std::array<Pl0500Param::BombStickyParam,8>

    [JsonPropertyName("scaleSize_")]
    public float ScaleSize { get; set; }

    [JsonPropertyName("scaleSize_ThrowAfter_")]
    public float ScaleSize_ThrowAfter { get; set; }

    [JsonPropertyName("throwHitRad_")]
    public float ThrowHitRad { get; set; }

    [JsonPropertyName("smallBomb_Gravity_")]
    public float SmallBomb_Gravity { get; set; }

    [JsonPropertyName("smallBomb_GravityRate_")]
    public float SmallBomb_GravityRate { get; set; }

    [JsonPropertyName("smallBomb_Spin_")]
    public float SmallBomb_Spin { get; set; }

    [JsonPropertyName("smallBomb_Speed_Y_")]
    public float SmallBomb_Speed_Y { get; set; }

    [JsonPropertyName("smallBomb_Speed_Z_")]
    public float SmallBomb_Speed_Z { get; set; }

    [JsonPropertyName("smallBomb_BoundRate_Y_")]
    public float SmallBomb_BoundRate_Y { get; set; }

    [JsonPropertyName("smallBomb_BoundRate_Z_")]
    public float SmallBomb_BoundRate_Z { get; set; }

    [JsonPropertyName("smallBombAddThrowRateMax_")]
    public float SmallBombAddThrowRateMax { get; set; }

    [JsonPropertyName("bigBomb_Gravity_")]
    public float BigBomb_Gravity { get; set; }

    [JsonPropertyName("bigBomb_GravityRate_")]
    public float BigBomb_GravityRate { get; set; }

    [JsonPropertyName("bigBomb_Speed_")]
    public float BigBomb_Speed { get; set; }

    [JsonPropertyName("bigBomb_FarRange_")]
    public float BigBomb_FarRange { get; set; }

    [JsonPropertyName("bigBomb_Spin_Near_")]
    public float BigBomb_Spin_Near { get; set; }

    [JsonPropertyName("bigBomb_Spin_Far_")]
    public float BigBomb_Spin_Far { get; set; }

    [JsonPropertyName("airBomb_SpeedRate_Z_")]
    public float AirBomb_SpeedRate_Z { get; set; }

    [JsonPropertyName("airBomb_SpeedRate_Y_")]
    public float AirBomb_SpeedRate_Y { get; set; }

    [JsonPropertyName("meleeAttackDist_")]
    public float MeleeAttackDist { get; set; }

    [JsonPropertyName("aimShotButtonInputTime_")]
    public float AimShotButtonInputTime { get; set; }

    [JsonPropertyName("aimShotIntervalTime_")]
    public float AimShotIntervalTime { get; set; }

    [JsonPropertyName("animShotAdjustX_")]
    public float AnimShotAdjustX { get; set; }

    [JsonPropertyName("animShotAdjustY_")]
    public float AnimShotAdjustY { get; set; }

    [JsonPropertyName("aimCamRate_")]
    public float AimCamRate { get; set; }

    [JsonPropertyName("aimCamSpeed_")]
    public float AimCamSpeed { get; set; }

    [JsonPropertyName("aimChargeFrame_")]
    public float AimChargeFrame { get; set; }

    [JsonPropertyName("aimBomb_Gravity_")]
    public float AimBomb_Gravity { get; set; }

    [JsonPropertyName("aimBomb_GravityRate_")]
    public float AimBomb_GravityRate { get; set; }

    [JsonPropertyName("aimBomb_Speed_")]
    public float AimBomb_Speed { get; set; }

    [JsonPropertyName("aimBomb_OffsetY_")]
    public float AimBomb_OffsetY { get; set; }

    [JsonPropertyName("airBomb_StartTime_")]
    public float AirBomb_StartTime { get; set; }

    [JsonPropertyName("airBomb_IntervalTime_")]
    public float AirBomb_IntervalTime { get; set; }

    [JsonPropertyName("airBomb_Num_")]
    public int AirBomb_Num { get; set; }

    [JsonPropertyName("airBomb_DistanceRate_")]
    public float AirBomb_DistanceRate { get; set; }

    [JsonPropertyName("laserAtkTime_")]
    public float LaserAtkTime { get; set; }

    [JsonPropertyName("laserAtkPow_")]
    public float LaserAtkPow { get; set; }

    [JsonPropertyName("laserAtkBreak_")]
    public float LaserAtkBreak { get; set; }

    [JsonPropertyName("laserAtkSpRate_")]
    public float LaserAtkSpRate { get; set; }

    // dupe?
    //[JsonPropertyName("laserAtkSpRate_")]
    //public float LaserAtkSpRate { get; set; }

    [JsonPropertyName("laserHitFrame_")]
    public float LaserHitFrame { get; set; }

    [JsonPropertyName("healBullet_rate_")]
    public float HealBullet_rate { get; set; }

    [JsonPropertyName("healBullet_limit_")]
    public float HealBullet_limit { get; set; }

    [JsonPropertyName("healDistance_")]
    public float HealDistance { get; set; }

    [JsonPropertyName("healDistance_Short_")]
    public float HealDistance_Short { get; set; }

    public class BombStickyParam // Pl0500Param::BombStickyParam
    {
        [JsonPropertyName("useOffsetNum")]
        public int UseOffsetNum { get; set; }

        [JsonPropertyName("objId_")]
        public int ObjId { get; set; }

        [JsonPropertyName("offsetParam_")]
        public BindingList<BombOffsetParam> OffsetParam { get; set; } = []; // std::array<Pl0500Param::BombOffsetParam,16>
    }

    public class BombOffsetParam // Pl0500Param::BombOffsetParam
    {
        [JsonPropertyName("partsNo_")]
        public int PartsNo { get; set; }

        [JsonPropertyName("trans_")]
        public /*cVec4*/ Vector4 Trans { get; set; }

        [JsonPropertyName("rot_")]
        public /*cVec4*/ Vector4 Rot { get; set; }

        [JsonPropertyName("dist_")]
        public float Dist { get; set; }
    }
}
