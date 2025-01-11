using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.Entities.Player;

namespace GBFRDataTools.Entities.Parameters;

public class Pl0300Param : PlayerParameterInfo
{
    [JsonPropertyName("heatGaugeCoolRate_")]
    public float HeatGaugeCoolRate { get; set; }

    [JsonPropertyName("notAppropriAtkHitVibRate_")]
    public float NotAppropriAtkHitVibRate { get; set; }

    [JsonPropertyName("walkingShoot_AddHeatGaugeRate_")]
    public float WalkingShoot_AddHeatGaugeRate { get; set; }

    [JsonPropertyName("walkingShoot_AddHeatGaugeRate_JustShot_")]
    public float WalkingShoot_AddHeatGaugeRate_JustShot { get; set; }

    [JsonPropertyName("addHeatGaugeSpitFire_")]
    public float AddHeatGaugeSpitFire { get; set; }

    [JsonPropertyName("addHeatGaugeBulletHail_")]
    public float AddHeatGaugeBulletHail { get; set; }

    [JsonPropertyName("addHeatGaugeCoffinmaker_")]
    public float AddHeatGaugeCoffinmaker { get; set; }

    [JsonPropertyName("addHeatGaugeSlagShot_")]
    public float AddHeatGaugeSlagShot { get; set; }

    [JsonPropertyName("addHeatGaugeCollateralDamage_")]
    public float AddHeatGaugeCollateralDamage { get; set; }

    [JsonPropertyName("addHeatGaugeLinkAtkRapid_")]
    public float AddHeatGaugeLinkAtkRapid { get; set; }

    [JsonPropertyName("addHeatGaugeLinkAtkFin_")]
    public float AddHeatGaugeLinkAtkFin { get; set; }

    [JsonPropertyName("disablereactionFrame_")]
    public float DisablereactionFrame { get; set; }

    [JsonPropertyName("burstShotNumByUniqueSkill_")]
    public int BurstShotNumByUniqueSkill { get; set; }

    [JsonPropertyName("burstShotFrameByUniqueSkill_")]
    public float BurstShotFrameByUniqueSkill { get; set; }

    [JsonPropertyName("chargeShot_ChargeTime_")]
    public float ChargeShot_ChargeTime { get; set; }

    [JsonPropertyName("chargeMaxShot_SubGauge_")]
    public float ChargeMaxShot_SubGauge { get; set; }

    [JsonPropertyName("cancelFrame_HeatLv2_")]
    public float CancelFrame_HeatLv2 { get; set; }

    [JsonPropertyName("cancelFrame_HeatLv3_")]
    public float CancelFrame_HeatLv3 { get; set; }

    [JsonPropertyName("cancelFrame_HeatLv4_")]
    public float CancelFrame_HeatLv4 { get; set; }

    [JsonPropertyName("cancelFrame_HeatLv5_")]
    public float CancelFrame_HeatLv5 { get; set; }

    [JsonPropertyName("bulletHaleLineCheckHeigh_")]
    public float BulletHaleLineCheckHeigh { get; set; }

    [JsonPropertyName("bulletHaleLineCheckLow_")]
    public float BulletHaleLineCheckLow { get; set; }

    [JsonPropertyName("doubleTapTime_")]
    public float DoubleTapTime { get; set; }

    [JsonPropertyName("fullfire_addAtkRate_")]
    public float Fullfire_addAtkRate { get; set; }

    [JsonPropertyName("fullfire_subAbilityGauge_")]
    public float Fullfire_subAbilityGauge { get; set; }

    [JsonPropertyName("meleeShot_DirY_")]
    public float MeleeShot_DirY { get; set; }

    [JsonPropertyName("meleeShot_DirX_")]
    public float MeleeShot_DirX { get; set; }

    [JsonPropertyName("overHeat_DefDown_Rate_")]
    public float OverHeat_DefDown_Rate { get; set; }

    [JsonPropertyName("overHeat_DefDown_Time_")]
    public float OverHeat_DefDown_Time { get; set; }

    [JsonPropertyName("heatGaugeMaxTime_")]
    public float HeatGaugeMaxTime { get; set; }

    [JsonPropertyName("collateralDamage_Dist_")]
    public float CollateralDamage_Dist { get; set; }

    [JsonPropertyName("collateralDamage_Time_")]
    public float CollateralDamage_Time { get; set; }

    [JsonPropertyName("collateralDamage_DirX_")]
    public float CollateralDamage_DirX { get; set; }

    [JsonPropertyName("collateralDamage_AiAvoidPercent_")]
    public int CollateralDamage_AiAvoidPercent { get; set; }

    [JsonPropertyName("duration_Speed_")]
    public float Duration_Speed { get; set; }

    [JsonPropertyName("duration_MoveTime_")]
    public float Duration_MoveTime { get; set; }

    [JsonPropertyName("duration_InputTimeRate_")]
    public float Duration_InputTimeRate { get; set; }

    [JsonPropertyName("shotgunMoveDistList_")]
    public BindingList<float> ShotgunMoveDistList { get; set; } = []; // std::array<float, 5>

    [JsonPropertyName("walkingShotTargetSelectParam_")]
    public PlayerLockOnParameter WalkingShotTargetSelectParam { get; set; }
}
