using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters.Player;

public class Pl0300Param : PlayerParameterInfo
{
    [JsonPropertyName("heatGaugeCoolRate_")]
    public float HeatGaugeCoolRate { get; set; } = 0.3f;

    [JsonPropertyName("notAppropriAtkHitVibRate_")]
    public float NotAppropriAtkHitVibRate { get; set; } = 0.25f;

    [JsonPropertyName("walkingShoot_AddHeatGaugeRate_")]
    public float WalkingShoot_AddHeatGaugeRate { get; set; } = 0.08f;

    [JsonPropertyName("walkingShoot_AddHeatGaugeRate_JustShot_")]
    public float WalkingShoot_AddHeatGaugeRate_JustShot { get; set; } = 0.5f;

    [JsonPropertyName("addHeatGaugeSpitFire_")]
    public float AddHeatGaugeSpitFire { get; set; } = 0.5f;

    [JsonPropertyName("addHeatGaugeBulletHail_")]
    public float AddHeatGaugeBulletHail { get; set; } = 0.1f;

    [JsonPropertyName("addHeatGaugeCoffinmaker_")]
    public float AddHeatGaugeCoffinmaker { get; set; } = 0.1f;

    [JsonPropertyName("addHeatGaugeSlagShot_")]
    public float AddHeatGaugeSlagShot { get; set; } = 0.1f;

    [JsonPropertyName("addHeatGaugeCollateralDamage_")]
    public float AddHeatGaugeCollateralDamage { get; set; } = 5f;

    [JsonPropertyName("addHeatGaugeLinkAtkRapid_")]
    public float AddHeatGaugeLinkAtkRapid { get; set; } = 0.4f;

    [JsonPropertyName("addHeatGaugeLinkAtkFin_")]
    public float AddHeatGaugeLinkAtkFin { get; set; } = 0.8f;

    [JsonPropertyName("disablereactionFrame_")]
    public float DisablereactionFrame { get; set; } = 15f;

    [JsonPropertyName("burstShotNumByUniqueSkill_")]
    public int BurstShotNumByUniqueSkill { get; set; } = 4;

    [JsonPropertyName("burstShotFrameByUniqueSkill_")]
    public float BurstShotFrameByUniqueSkill { get; set; } = 4f;

    [JsonPropertyName("chargeShot_ChargeTime_")]
    public float ChargeShot_ChargeTime { get; set; } = 5f;

    [JsonPropertyName("chargeMaxShot_SubGauge_")]
    public float ChargeMaxShot_SubGauge { get; set; } = 1f;

    [JsonPropertyName("cancelFrame_HeatLv2_")]
    public float CancelFrame_HeatLv2 { get; set; } = 40f;

    [JsonPropertyName("cancelFrame_HeatLv3_")]
    public float CancelFrame_HeatLv3 { get; set; } = 30f;

    [JsonPropertyName("cancelFrame_HeatLv4_")]
    public float CancelFrame_HeatLv4 { get; set; } = 20f;

    [JsonPropertyName("cancelFrame_HeatLv5_")]
    public float CancelFrame_HeatLv5 { get; set; } = 10f;

    [JsonPropertyName("bulletHaleLineCheckHeigh_")]
    public float BulletHaleLineCheckHeigh { get; set; } = 10f;

    [JsonPropertyName("bulletHaleLineCheckLow_")]
    public float BulletHaleLineCheckLow { get; set; } = -20f;

    [JsonPropertyName("doubleTapTime_")]
    public float DoubleTapTime { get; set; } = 30f;

    [JsonPropertyName("fullfire_addAtkRate_")]
    public float Fullfire_addAtkRate { get; set; } = 0.06f;

    [JsonPropertyName("fullfire_subAbilityGauge_")]
    public float Fullfire_subAbilityGauge { get; set; } = 0.005f;

    [JsonPropertyName("meleeShot_DirY_")]
    public float MeleeShot_DirY { get; set; } = 8f;

    [JsonPropertyName("meleeShot_DirX_")]
    public float MeleeShot_DirX { get; set; } = 0f;

    [JsonPropertyName("overHeat_DefDown_Rate_")]
    public float OverHeat_DefDown_Rate { get; set; } = 0.3f;

    [JsonPropertyName("overHeat_DefDown_Time_")]
    public float OverHeat_DefDown_Time { get; set; } = 30f;

    [JsonPropertyName("heatGaugeMaxTime_")]
    public float HeatGaugeMaxTime { get; set; } = 10f;

    [JsonPropertyName("collateralDamage_Dist_")]
    public float CollateralDamage_Dist { get; set; } = 8f;

    [JsonPropertyName("collateralDamage_Time_")]
    public float CollateralDamage_Time { get; set; } = 5f;

    [JsonPropertyName("collateralDamage_DirX_")]
    public float CollateralDamage_DirX { get; set; } = -70f;

    [JsonPropertyName("collateralDamage_AiAvoidPercent_")]
    public int CollateralDamage_AiAvoidPercent { get; set; } = 75;

    [JsonPropertyName("duration_Speed_")]
    public float Duration_Speed { get; set; } = 0.45f;

    [JsonPropertyName("duration_MoveTime_")]
    public float Duration_MoveTime { get; set; } = 0.8f;

    [JsonPropertyName("duration_InputTimeRate_")]
    public float Duration_InputTimeRate { get; set; } = 0.3f;

    [JsonPropertyName("shotgunMoveDistList_")]
    [Editable(false)]
    public BindingList<float> ShotgunMoveDistList { get; set; } = [.. Enumerable.Repeat(0, 5).ToList()]; // std::array<float, 5>

    [JsonPropertyName("walkingShotTargetSelectParam_")]
    public PlayerLockOnParameter WalkingShotTargetSelectParam { get; set; }

    public Pl0300Param()
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
        LimitSpecialArtsDamageRate = 0.9f;
        LimitAbilityDamageRate = 1.8f;
        AiMoveNotargetDistance = 20f;
        DamageLimitNormalAttack = 1999;
        DamageLimitNormalAttack2 = 4999;
        DamageLimitSpecialAttack = 39999;
        DamageLimitAbility01 = 44999;
        DamageLimitAbility02 = 6999;
        DamageLimitAbility03 = 4999;
        DamageLimitAbility04 = 4999;
        DamageLimitAbility05 = 5999;
        DamageLimitAbility06 = 4999;
        DamageLimitAbility07 = 4999;
        DamageLimitAbility08 = 249999;
        DamageLimitLinkAttack = 9999;
        DamageLimitSpecialArtsStart = 99999;
        DamageLimitSpecialArts = 44999;
    }
}
