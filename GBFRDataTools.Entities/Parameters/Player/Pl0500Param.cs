using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0500Param : PlayerParameterInfo
{
    [JsonPropertyName("useParamNum")]
    public int UseParamNum { get; set; }

    [JsonPropertyName("bombStickyParam_")]
    [Editable(false)]
    public BindingList<BombStickyParam> BombStickyParam_ { get; set; } = [.. Enumerable.Repeat(new BombStickyParam(), 8).ToList()]; // std::array<Pl0500Param::BombStickyParam,8>

    [JsonPropertyName("scaleSize_")]
    public float ScaleSize { get; set; } = 1f;

    [JsonPropertyName("scaleSize_ThrowAfter_")]
    public float ScaleSize_ThrowAfter { get; set; } = 1.25f;

    [JsonPropertyName("throwHitRad_")]
    public float ThrowHitRad { get; set; } = 1f;

    [JsonPropertyName("smallBomb_Gravity_")]
    public float SmallBomb_Gravity { get; set; } = 1.1f;

    [JsonPropertyName("smallBomb_GravityRate_")]
    public float SmallBomb_GravityRate { get; set; } = 1.1f;

    [JsonPropertyName("smallBomb_Spin_")]
    public float SmallBomb_Spin { get; set; } = 10f;

    [JsonPropertyName("smallBomb_Speed_Y_")]
    public float SmallBomb_Speed_Y { get; set; } = 0.06f;

    [JsonPropertyName("smallBomb_Speed_Z_")]
    public float SmallBomb_Speed_Z { get; set; } = 0.1f;

    [JsonPropertyName("smallBomb_BoundRate_Y_")]
    public float SmallBomb_BoundRate_Y { get; set; } = 0.05f;

    [JsonPropertyName("smallBomb_BoundRate_Z_")]
    public float SmallBomb_BoundRate_Z { get; set; } = 0.05f;

    [JsonPropertyName("smallBombAddThrowRateMax_")]
    public float SmallBombAddThrowRateMax { get; set; } = 2.5f;

    [JsonPropertyName("bigBomb_Gravity_")]
    public float BigBomb_Gravity { get; set; } = 1.3f;

    [JsonPropertyName("bigBomb_GravityRate_")]
    public float BigBomb_GravityRate { get; set; } = 1.3f;

    [JsonPropertyName("bigBomb_Speed_")]
    public float BigBomb_Speed { get; set; } = 1f;

    [JsonPropertyName("bigBomb_FarRange_")]
    public float BigBomb_FarRange { get; set; } = 0.15f;

    [JsonPropertyName("bigBomb_Spin_Near_")]
    public float BigBomb_Spin_Near { get; set; } = 1.3f;

    [JsonPropertyName("bigBomb_Spin_Far_")]
    public float BigBomb_Spin_Far { get; set; } = 15f;

    [JsonPropertyName("airBomb_SpeedRate_Z_")]
    public float AirBomb_SpeedRate_Z { get; set; } = 0.05f;

    [JsonPropertyName("airBomb_SpeedRate_Y_")]
    public float AirBomb_SpeedRate_Y { get; set; } = -0.05f;

    [JsonPropertyName("meleeAttackDist_")]
    public float MeleeAttackDist { get; set; } = 4.5f;

    [JsonPropertyName("aimShotButtonInputTime_")]
    public float AimShotButtonInputTime { get; set; } = 0.3f;

    [JsonPropertyName("aimShotIntervalTime_")]
    public float AimShotIntervalTime { get; set; } = 0.5f;

    [JsonPropertyName("animShotAdjustX_")]
    public float AnimShotAdjustX { get; set; } = -1460f;

    [JsonPropertyName("animShotAdjustY_")]
    public float AnimShotAdjustY { get; set; } = -290f;

    [JsonPropertyName("aimCamRate_")]
    public float AimCamRate { get; set; } = 0.5f;

    [JsonPropertyName("aimCamSpeed_")]
    public float AimCamSpeed { get; set; } = 0.4f;

    [JsonPropertyName("aimChargeFrame_")]
    public float AimChargeFrame { get; set; } = 45f;

    [JsonPropertyName("aimBomb_Gravity_")]
    public float AimBomb_Gravity { get; set; } = 0.7f;

    [JsonPropertyName("aimBomb_GravityRate_")]
    public float AimBomb_GravityRate { get; set; } = 0.7f;

    [JsonPropertyName("aimBomb_Speed_")]
    public float AimBomb_Speed { get; set; } = 0.3f;

    [JsonPropertyName("aimBomb_OffsetY_")]
    public float AimBomb_OffsetY { get; set; } = 5f;

    [JsonPropertyName("airBomb_StartTime_")]
    public float AirBomb_StartTime { get; set; } = 0.5f;

    [JsonPropertyName("airBomb_IntervalTime_")]
    public float AirBomb_IntervalTime { get; set; } = 0.22f;

    [JsonPropertyName("airBomb_Num_")]
    public int AirBomb_Num { get; set; } = 10;

    [JsonPropertyName("airBomb_DistanceRate_")]
    public float AirBomb_DistanceRate { get; set; } = 1f;

    [JsonPropertyName("laserAtkTime_")]
    public float LaserAtkTime { get; set; } = 5f;

    [JsonPropertyName("laserAtkPow_")]
    public float LaserAtkPow { get; set; } = 1.8f;

    [JsonPropertyName("laserAtkBreak_")]
    public float LaserAtkBreak { get; set; } = 0.4f;

    [JsonPropertyName("laserAtkSpRate_")]
    public float LaserAtkSpRate { get; set; } = 0.25f;

    [JsonPropertyName("laserHitFrame_")]
    public float LaserHitFrame { get; set; } = 15f;

    [JsonPropertyName("healBullet_rate_")]
    public float HealBullet_rate { get; set; } = 0.6f;

    [JsonPropertyName("healBullet_limit_")]
    public float HealBullet_limit { get; set; } = 20000f;

    [JsonPropertyName("healDistance_")]
    public float HealDistance { get; set; } = 4.5f;

    [JsonPropertyName("healDistance_Short_")]
    public float HealDistance_Short { get; set; } = 8f;

    public Pl0500Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 75;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        MaxLvHp = 30000;
        MaxLvAtk = 240;
        MaxLvDef = 1.05f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 0.6f;
        LimitSpecialArtsDamageRate = 0.7999999f;
        LimitAbilityDamageRate = 2f;
        AiMoveNotargetDistance = 18f;
        DamageLimitNormalAttack = 14999;
        DamageLimitNormalAttack2 = 24999;
        DamageLimitSpecialAttack = 74999;
        DamageLimitAbility01 = 14999;
        DamageLimitAbility02 = 149999;
        DamageLimitAbility03 = 69999;
        DamageLimitAbility04 = 44999;
        DamageLimitAbility05 = 19999;
        DamageLimitAbility06 = 19999;
        DamageLimitAbility07 = 1;
        DamageLimitAbility08 = 9999;
        DamageLimitLinkAttack = 99999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 129999;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class BombStickyParam // Pl0500Param::BombStickyParam
    {
        [JsonPropertyName("useOffsetNum")]
        public int UseOffsetNum { get; set; }

        [JsonPropertyName("objId_")]
        public int ObjId { get; set; }

        [JsonPropertyName("offsetParam_")]
        [Editable(false)]
        public BindingList<BombOffsetParam> OffsetParam { get; set; } = [.. Enumerable.Repeat(new BombOffsetParam(), 16).ToList()]; // std::array<Pl0500Param::BombOffsetParam,16>
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
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
