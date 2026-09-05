using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Weapon.We2100;
using GBFRDataTools.Entities.Player;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Pl2700Param : PlayerParameterInfo
{
    [JsonPropertyName("uniqueLinkTimeBonusRate_")]
    public float UniqueLinkTimeBonusRate { get; set; } = 30f; 

    [JsonPropertyName("closeShotDist_")]
    public float CloseShotDist { get; set; } = 1.5f; 

    [JsonPropertyName("heightBlendAdjustRate_")]
    public float HeightBlendAdjustRate { get; set; } = 2f; 

    [JsonPropertyName("heightBlendDownAdjustRate_")]
    public float HeightBlendDownAdjustRate { get; set; } = 1.75f; 

    [JsonPropertyName("finishShotSeLength_")]
    public float FinishShotSeLength { get; set; } = 40f; 

    [JsonPropertyName("finishShotSeStopTime_")]
    public float FinishShotSeStopTime { get; set; } = 0.55f; 

    [JsonPropertyName("chargeShotSecMax_")]
    public float ChargeShotSecMax { get; set; } = 0.7f; 

    [JsonPropertyName("chargeShotSecMin_")]
    public float ChargeShotSecMin { get; set; } = 0.5f; 

    [JsonPropertyName("fullChargeSec_")]
    public float FullChargeSec { get; set; } = 1f; 

    [JsonPropertyName("fullChargeSecLinkTime_")]
    public float FullChargeSecLinkTime { get; set; } = 0.5f; 

    [JsonPropertyName("chargeShotGaugeRateMax_")]
    public float ChargeShotGaugeRateMax { get; set; } = 150f; 

    [JsonPropertyName("burstShotAngle_")]
    public float BurstShotAngle { get; set; } = 5f;

    [JsonPropertyName("sweetDistanceParamList_")]
    public BindingList<SweetDistanceParam> SweetDistanceParamList { get; set; } = []; // std::vector<Pl2700Param::SweetDistanceParam>

    [JsonPropertyName("stepMoveCutRate_NoEnemy_")]
    public float StepMoveCutRate_NoEnemy { get; set; } = 0.75f; 

    [JsonPropertyName("rushMoveCutRate_NoEnemy_")]
    public float RushMoveCutRate_NoEnemy { get; set; } = 0.3f; 

    [JsonPropertyName("stepInvincibleFrame_")]
    public int StepInvincibleFrame { get; set; } = 10; 

    [JsonPropertyName("defaultBulletCount_")]
    public int DefaultBulletCount { get; set; } = 5; 

    [JsonPropertyName("overpressureBulletCount_")]
    public int OverpressureBulletCount { get; set; } = 5; 

    [JsonPropertyName("justReloadTime_")]
    public float JustReloadTime { get; set; } = 0.5f; 

    [JsonPropertyName("overpressureGaugeMaxPoint_")]
    public float OverpressureGaugeMaxPoint { get; set; } = 1000f; 

    [JsonPropertyName("overpressureGaugePoint_LinkAttack_")]
    public float OverpressureGaugePoint_LinkAttack { get; set; } = 1000f; 

    [JsonPropertyName("overpressureGaugePoint_Ability5_")]
    public float OverpressureGaugePoint_Ability5 { get; set; } = 200f;

    [JsonPropertyName("justReloadIncreaseDataList_")]
    public BindingList<GageAddParam> JustReloadIncreaseDataList { get; set; } = []; // std::vector<Pl2700Param::GageAddParam>

    [JsonPropertyName("overpressureIncreaseDataList_")]
    public BindingList<GageAddParam> OverpressureIncreaseDataList { get; set; } = []; // std::vector<Pl2700Param::GageAddParam>

    [JsonPropertyName("stepTargetSelectParam_")]
    public PlayerLockOnParameter StepTargetSelectParam { get; set; } = new();

    [JsonPropertyName("stepContinueTargetSelectParam_")]
    public PlayerLockOnParameter StepContinueTargetSelectParam { get; set; } = new();

    [JsonPropertyName("uniqueBuffSec_")]
    public float UniqueBuffSec { get; set; } = 30f; 

    [JsonPropertyName("uniqueBuffAttackRate_")]
    public float UniqueBuffAttackRate { get; set; } = 30f; 

    [JsonPropertyName("uniqueBuffGaugeRate_")]
    public float UniqueBuffGaugeRate { get; set; } = 100f; 

    [JsonPropertyName("wideShotStickSensitivity_")]
    public float WideShotStickSensitivity { get; set; } = 10f; 

    [JsonPropertyName("wideShotCountLv0_")]
    public int WideShotCountLv0 { get; set; } = 5; 

    [JsonPropertyName("wideShotCountLv1_")]
    public int WideShotCountLv1 { get; set; } = 5; 

    [JsonPropertyName("wideShotAngleX_")]
    public float WideShotAngleX { get; set; } = -10f; 

    [JsonPropertyName("wideShotAngleXAdd_")]
    public float WideShotAngleXAdd { get; set; } = 0f; 

    [JsonPropertyName("wideShotAngleY_")]
    public float WideShotAngleY { get; set; } = 90f; 

    [JsonPropertyName("wideShotAngleYMin_")]
    public float WideShotAngleYMin { get; set; } = 0.15f; 

    [JsonPropertyName("wideShotAllSec_")]
    public float WideShotAllSec { get; set; } = 0f; 

    [JsonPropertyName("wideShotRootAngleX_")]
    public float WideShotRootAngleX { get; set; } = 45f; 

    [JsonPropertyName("wideShotRootOffset_")]
    public Vector4 WideShotRootOffset { get; set; } = new Vector4(0f, 0f, 0.25f, 1f); 

    [JsonPropertyName("wideShotOffset_")]
    public Vector4 WideShotOffset { get; set; } = new Vector4(0f, 0.25f, 0.2f, 1f); 

    [JsonPropertyName("wideShotChargeOffset_")]
    public Vector4 WideShotChargeOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); 

    [JsonPropertyName("diffusionCount_")]
    public int DiffusionCount { get; set; } = 7; 

    [JsonPropertyName("diffusionIntervalSec_")]
    public float DiffusionIntervalSec { get; set; } = 0.1f; 

    [JsonPropertyName("maxDiffusionLength_")]
    public float MaxDiffusionLength { get; set; } = 25f; 

    [JsonPropertyName("satelliteInterval_")]
    public float SatelliteInterval { get; set; } = 0.3f; 

    [JsonPropertyName("satelliteHeight_")]
    public float SatelliteHeight { get; set; } = 10f; 

    [JsonPropertyName("satelliteRadius_")]
    public float SatelliteRadius { get; set; } = 5f; 

    [JsonPropertyName("satelliteRingAdjust_")]
    public float SatelliteRingAdjust { get; set; } = 1.2f; 

    [JsonPropertyName("satelliteParalyzeTime_")]
    public float SatelliteParalyzeTime { get; set; } = 3f; 

    [JsonPropertyName("satelliteParamList_")]
    public BindingList<SatelliteAttackParam> SatelliteParamList { get; set; } = []; // std::vector<Pl2700Param::SatelliteAttackParam>

    [JsonPropertyName("aiJustStepProbability_")]
    public float AiJustStepProbability { get; set; } = 50f; 

    [JsonPropertyName("markingHitExplosionDelay_")]
    public float MarkingHitExplosionDelay { get; set; } = 0.66f; 

    [JsonPropertyName("markingCausionDelay_")]
    public float MarkingCausionDelay { get; set; } = 0.33f; 

    [JsonPropertyName("markingCausionExplosionDelay_")]
    public float MarkingCausionExplosionDelay { get; set; } = 0f;

    [JsonPropertyName("sephiraMotionList_")]
    public BindingList<SephiraMotionParam> SephiraMotionList { get; set; } = []; // std::vector<Pl2700Param::SephiraMotionParam>

    [JsonPropertyName("gaugeDefaultPos_")]
    public Vector4 GaugeDefaultPos { get; set; } = new Vector4(100f, 120f, 0f, 1f); 

    [JsonPropertyName("gaugeDefaultSize_")]
    public Vector4 GaugeDefaultSize { get; set; } = new Vector4(200f, 16f, 0f, 1f); 

    [JsonPropertyName("gaugeCompactPos_")]
    public Vector4 GaugeCompactPos { get; set; } = new Vector4(-52f, 52f, 0f, 1f); 

    [JsonPropertyName("gaugeCompactSize_")]
    public Vector4 GaugeCompactSize { get; set; } = new Vector4(100f, 12f, 0f, 1f); 

    [JsonPropertyName("bulletDefaultPos_")]
    public Vector4 BulletDefaultPos { get; set; } = new Vector4(96f, 100f, 0f, 1f); 

    [JsonPropertyName("bulletDefaultSize_")]
    public Vector4 BulletDefaultSize { get; set; } = new Vector4(200f, 16f, 0f, 1f); 

    [JsonPropertyName("bulletCompactPos_")]
    public Vector4 BulletCompactPos { get; set; } = new Vector4(-52f, 32f, 0f, 1f); 

    [JsonPropertyName("bulletCompactSize_")]
    public Vector4 BulletCompactSize { get; set; } = new Vector4(100f, 16f, 0f, 1f); 

    public Pl2700Param()
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
        MaxLvDef = 2f;
        MaxLvExp = 300000;
        CriticalBaseRate = 0.09999999f;
        BaseBreakPower = 10;
        LimitDamageRate = 1f;
        LimitSpecialArtsDamageRate = 1f;
        LimitAbilityDamageRate = 1f;
        AiMoveNotargetDistance = 20f;
        DamageLimitMin = 999;
        DamageLimitMax = 999999;
        AtkRateMin = 0.1f;
        AtkRateMax = 100f;
        IsSetExtraWeaponMotion = false;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class GageAddParam /* Pl2700Param::GageAddParam */
    {
        [JsonPropertyName("actionID_")]
        public int ActionID { get; set; } 
    
        [JsonPropertyName("increasePoint_")]
        public float IncreasePoint { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SatelliteAttackParam /* Pl2700Param::SatelliteAttackParam */
    {
        [JsonPropertyName("atkRate_")]
        public float AtkRate { get; set; } 
    
        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } 
    
        [JsonPropertyName("spArtsRate_")]
        public float SpArtsRate { get; set; } 
    
        [JsonPropertyName("lvUpTime_")]
        public float LvUpTime { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SephiraMotionParam /* Pl2700Param::SephiraMotionParam */
    {
        [JsonPropertyName("animName_")]
        public string? AnimName { get; set; } 
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class SweetDistanceParam /* Pl2700Param::SweetDistanceParam */
    {
        [JsonPropertyName("distanceMin_")]
        public float DistanceMin { get; set; } 
    
        [JsonPropertyName("distanceMax_")]
        public float DistanceMax { get; set; } 
    
        [JsonPropertyName("rate_")]
        public float Rate { get; set; } 
    }
}