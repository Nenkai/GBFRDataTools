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

using static GBFRDataTools.Entities.Parameters.Player.Pl2200Param;

namespace GBFRDataTools.Entities.Parameters.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Pl2500Param : PlayerParameterInfo
{
    [JsonPropertyName("swordEmissiveParam_")]
    public Wp2500SwordEmissiveParam SwordEmissiveParam { get; set; } 

    [JsonPropertyName("defaultLv_")]
    public int DefaultLv { get; set; } = 1; 

    [JsonPropertyName("defaultPoint_")]
    public float DefaultPoint { get; set; } = 500f; 

    [JsonPropertyName("decreaseAmount_")]
    public float DecreaseAmount { get; set; } = 100f; 

    [JsonPropertyName("shotTimeMax_")]
    public float ShotTimeMax { get; set; } = 4.5f; 

    [JsonPropertyName("increaseAmount_NormalAtk_3rd_")]
    public float IncreaseAmount_NormalAtk_3rd { get; set; } = 0.2f; 

    [JsonPropertyName("increaseAmount_PowAtk_1st_")]
    public float IncreaseAmount_PowAtk_1st { get; set; } = 1.13f; 

    [JsonPropertyName("increaseAmount_PowAtk_2nd_")]
    public float IncreaseAmount_PowAtk_2nd { get; set; } = 1f; 

    [JsonPropertyName("increaseAmount_PowAtk_3rd_")]
    public float IncreaseAmount_PowAtk_3rd { get; set; } = 1.1f; 

    [JsonPropertyName("increaseAmount_Ability6_Attack_")]
    public float IncreaseAmount_Ability6_Attack { get; set; } = 10f; 

    [JsonPropertyName("increaseAmount_Ability6_Avoid_")]
    public float IncreaseAmount_Ability6_Avoid { get; set; } = 100f; 

    [JsonPropertyName("increaseAmount_AddAtk_")]
    public float IncreaseAmount_AddAtk { get; set; } = 30f; 

    [JsonPropertyName("increaseAmount_LinkAttack_")]
    public float IncreaseAmount_LinkAttack { get; set; } = 80f; 

    [JsonPropertyName("maxAdjustmentDegree_")]
    public float MaxAdjustmentDegree { get; set; } = 45f; 

    [JsonPropertyName("weaponStayTime_1st_")]
    public float WeaponStayTime_1st { get; set; } = 1.5f; 

    [JsonPropertyName("weaponStayTime_2nd_")]
    public float WeaponStayTime_2nd { get; set; } = 2.7f; 

    [JsonPropertyName("weaponStayTime_3rd_")]
    public float WeaponStayTime_3rd { get; set; } = 3.9f; 

    [JsonPropertyName("weaponAttackTime_1st_")]
    public float WeaponAttackTime_1st { get; set; } = 5f; 

    [JsonPropertyName("weaponAttackTime_2nd_")]
    public float WeaponAttackTime_2nd { get; set; } = 6f; 

    [JsonPropertyName("weaponAttackTime_3rd_")]
    public float WeaponAttackTime_3rd { get; set; } = 25f; 

    [JsonPropertyName("gearOperationTime_")]
    public float GearOperationTime { get; set; } = 0.7f; 

    [JsonPropertyName("gearRushLoopTime_")]
    public float GearRushLoopTime { get; set; } = 0.2f; 

    [JsonPropertyName("weaponMotBlendTime_")]
    public float WeaponMotBlendTime { get; set; } = 5f; 

    [JsonPropertyName("isRepeatBlend_")]
    public bool IsRepeatBlend { get; set; } = true; 

    [JsonPropertyName("repeatBlendNum_")]
    public float RepeatBlendNum { get; set; } = 0.5f; 

    [JsonPropertyName("upperHitCount_1st_")]
    public int UpperHitCount_1st { get; set; } = 0; 

    [JsonPropertyName("upperHitCount_2nd_")]
    public int UpperHitCount_2nd { get; set; } = 24; 

    [JsonPropertyName("upperHitCount_3rd_")]
    public int UpperHitCount_3rd { get; set; } = 17; 

    [JsonPropertyName("upperGaugeRate_1st_")]
    public float UpperGaugeRate_1st { get; set; } = 2f; 

    [JsonPropertyName("upperGaugeRate_2nd_")]
    public float UpperGaugeRate_2nd { get; set; } = 1.2f; 

    [JsonPropertyName("upperGaugeRate_3rd_")]
    public float UpperGaugeRate_3rd { get; set; } = 1.1f; 

    [JsonPropertyName("angularVelocity_1st_")]
    public float AngularVelocity_1st { get; set; } = 4.5f; 

    [JsonPropertyName("angularVelocity_3rd_")]
    public float AngularVelocity_3rd { get; set; } = 4f; 

    [JsonPropertyName("speedRate_1st_move_")]
    public float SpeedRate_1st_move { get; set; } = 1.4f; 

    [JsonPropertyName("speedRate_1st_stay_")]
    public float SpeedRate_1st_stay { get; set; } = 4f; 

    [JsonPropertyName("speedRate_1st_lowerLimit_")]
    public float SpeedRate_1st_lowerLimit { get; set; } = 0.3f; 

    [JsonPropertyName("speedRate_3rd_move_")]
    public float SpeedRate_3rd_move { get; set; } = 1.5f; 

    [JsonPropertyName("speedRate_3rd_stay_")]
    public float SpeedRate_3rd_stay { get; set; } = 1.5f; 

    [JsonPropertyName("speedRate_3rd_lowerLimit_")]
    public float SpeedRate_3rd_lowerLimit { get; set; } = 0.3f; 

    [JsonPropertyName("followSpeed_")]
    public float FollowSpeed { get; set; } = 20f; 

    [JsonPropertyName("isUseAvoidStop_")]
    public bool IsUseAvoidStop { get; set; } = false; 

    [JsonPropertyName("cameraCorrectionDistThreshold_")]
    public float CameraCorrectionDistThreshold { get; set; } = 15f; 

    [JsonPropertyName("farCameraCorrectionHeight_")]
    public float FarCameraCorrectionHeight { get; set; } = 1.5f; 

    [JsonPropertyName("farCameraCorrectionWidth_")]
    public float FarCameraCorrectionWidth { get; set; } = 2.5f; 

    [JsonPropertyName("nearCameraCorrectionDist_")]
    public float NearCameraCorrectionDist { get; set; } = 4f; 

    [JsonPropertyName("isUseFarCameraWidthCorrection_")]
    public bool IsUseFarCameraWidthCorrection { get; set; } = true; 

    [JsonPropertyName("isEnemyPosStart_1st_")]
    public bool IsEnemyPosStart_1st { get; set; } = false; 

    [JsonPropertyName("isEnemyPosStart_3rd_")]
    public bool IsEnemyPosStart_3rd { get; set; } = false; 

    [JsonPropertyName("graduallyBlendTime_1st_")]
    public float GraduallyBlendTime_1st { get; set; } = 1.7f; 

    [JsonPropertyName("graduallyBlendTime_3rd_")]
    public float GraduallyBlendTime_3rd { get; set; } = 2.7f; 

    [JsonPropertyName("turnInputMarginDegree_")]
    public float TurnInputMarginDegree { get; set; } = 45f; 

    [JsonPropertyName("turnRecastTime_")]
    public float TurnRecastTime { get; set; } = 0f; 

    [JsonPropertyName("graduallyBlendTimeAccelerationRate_")]
    public float GraduallyBlendTimeAccelerationRate { get; set; } = 3f; 

    [JsonPropertyName("graduallyBlendTimeDecelerationRate_")]
    public float GraduallyBlendTimeDecelerationRate { get; set; } = 1f; 

    [JsonPropertyName("targetMarkerCameraKeepTime_")]
    public float TargetMarkerCameraKeepTime { get; set; } = 1.5f; 

    [JsonPropertyName("isValidOperationSafety_")]
    public bool IsValidOperationSafety { get; set; } = true; 

    [JsonPropertyName("operationSafetyDist_")]
    public float OperationSafetyDist { get; set; } = 100f; 

    [JsonPropertyName("moveAngleLimit_")]
    public float MoveAngleLimit { get; set; } = 45f; 

    [JsonPropertyName("fallingSpeed_")]
    public float FallingSpeed { get; set; } = 100f; 

    [JsonPropertyName("shotCreatePosXOffset_")]
    public float ShotCreatePosXOffset { get; set; } = 1f; 

    [JsonPropertyName("shotCreatePosYOffset_")]
    public float ShotCreatePosYOffset { get; set; } = 0.7f; 

    [JsonPropertyName("shotDirRangeBase_")]
    public float ShotDirRangeBase { get; set; } = 35f; 

    [JsonPropertyName("shotDirOffset_")]
    public float ShotDirOffset { get; set; } = 0f; 

    [JsonPropertyName("shotCreatePosRandomOffsetRate_")]
    public float ShotCreatePosRandomOffsetRate { get; set; } = 0.3f; 

    [JsonPropertyName("shotStackAddTimeLv1_")]
    public float ShotStackAddTimeLv1 { get; set; } = 1.5f; 

    [JsonPropertyName("shotStackAddTimeLv2_")]
    public float ShotStackAddTimeLv2 { get; set; } = 1.5f; 

    [JsonPropertyName("shotStackAddTimeLv3_")]
    public float ShotStackAddTimeLv3 { get; set; } = 1.5f; 

    [JsonPropertyName("shotHormingDist_")]
    public float ShotHormingDist { get; set; } = 150f; 

    [JsonPropertyName("aimCameraSpeed_")]
    public float AimCameraSpeed { get; set; } = 0.6f; 

    [JsonPropertyName("shotHormingSetIntervalFrame_")]
    public int ShotHormingSetIntervalFrame { get; set; } = 6;

    [JsonPropertyName("forceAimTargetObjIdList")]
    [eObjId]
    public BindingList<int> ForceAimTargetObjIdList { get; set; } = []; // std::vector<int>

    [JsonPropertyName("checkNearBattleAreaObjIdList")]
    [eObjId]
    public BindingList<int> CheckNearBattleAreaObjIdList { get; set; } = []; // std::vector<int>

    [JsonPropertyName("isAcceptTurnInput_1st_")]
    public bool IsAcceptTurnInput_1st { get; set; } = false; 

    [JsonPropertyName("isAcceptTurnInput_3rd_")]
    public bool IsAcceptTurnInput_3rd { get; set; } = true; 

    [JsonPropertyName("getAccelerationRate_")]
    public float GetAccelerationRate { get; set; } = 2f; 

    [JsonPropertyName("isAccelerateWeapon_")]
    public bool IsAccelerateWeapon { get; set; } = true; 

    [JsonPropertyName("isAccelerateWeaponByNormalAttack_")]
    public bool IsAccelerateWeaponByNormalAttack { get; set; } = false;

    [JsonPropertyName("meshControlParamList_")]
    public BindingList<WeaponMeshControlParam> MeshControlParamList { get; set; } = []; // std::vector<Pl2500Param::WeaponMeshControlParam>

    [JsonPropertyName("viewAngle_ability2_")]
    public float ViewAngle_ability2 { get; set; } = -110f; 

    [JsonPropertyName("ability4_stayLoopSec_")]
    public float Ability4_stayLoopSec { get; set; } = 2.9f; 

    [JsonPropertyName("ability4_speedDownRate_")]
    public float Ability4_speedDownRate { get; set; } = 95f; 

    [JsonPropertyName("ability4_speedDownKeepSec_")]
    public float Ability4_speedDownKeepSec { get; set; } = 0.2f; 

    [JsonPropertyName("ability4_moveEndWaitSec_")]
    public float Ability4_moveEndWaitSec { get; set; } = 3f; 

    [JsonPropertyName("ability4_rotInterFrame_")]
    public int Ability4_rotInterFrame { get; set; } = 5; 

    [JsonPropertyName("ability4_maxHitCount_")]
    public int Ability4_maxHitCount { get; set; } = 15; 

    [JsonPropertyName("maxTime_ability5_")]
    public float MaxTime_ability5 { get; set; } = 10f; 

    [JsonPropertyName("invincibleTime_ability5_")]
    public float InvincibleTime_ability5 { get; set; } = 1f; 

    [JsonPropertyName("invincibleTime_ability5_lastSpell_")]
    public float InvincibleTime_ability5_lastSpell { get; set; } = 5f; 

    [JsonPropertyName("areaVfxScale_ability5_")]
    public float AreaVfxScale_ability5 { get; set; } = 4.5f; 

    [JsonPropertyName("spinSpeedPerSec_ability5_")]
    public float SpinSpeedPerSec_ability5 { get; set; } = 10f; 

    [JsonPropertyName("aimShotAtkRate_ability8_")]
    public float AimShotAtkRate_ability8 { get; set; } = 0.5f; 

    [JsonPropertyName("upperGaugeRate_ability8_")]
    public float UpperGaugeRate_ability8 { get; set; } = 0.5f; 

    [JsonPropertyName("hitNumToUpperRate_ability8_")]
    public float HitNumToUpperRate_ability8 { get; set; } = 0.5f; 

    [JsonPropertyName("motChangeHeight_")]
    public float MotChangeHeight { get; set; } = 1f; 

    [JsonPropertyName("wp2592_aliveTime_")]
    public float Wp2592_aliveTime { get; set; } = 30f; 

    [JsonPropertyName("wp2592_healingAreaRadius_")]
    public float Wp2592_healingAreaRadius { get; set; } = 8f; 

    [JsonPropertyName("wp2592_healingCycle_")]
    public float Wp2592_healingCycle { get; set; } = 3f; 

    [JsonPropertyName("wp2592_intarvalSearchHealingTargetSec_")]
    public float Wp2592_intarvalSearchHealingTargetSec { get; set; } = 5f; 

    [JsonPropertyName("wp2592_followEndDistance_")]
    public float Wp2592_followEndDistance { get; set; } = 5f; 

    [JsonPropertyName("wp2592_searchDistance_")]
    public float Wp2592_searchDistance { get; set; } = 50f; 

    [JsonPropertyName("wp2592_followOffset_")]
    public float Wp2592_followOffset { get; set; } = 3f; 

    [JsonPropertyName("wp2592_waitAreaWidth_")]
    public float Wp2592_waitAreaWidth { get; set; } = 0.5f; 

    [JsonPropertyName("wp2592_speedRate_")]
    public float Wp2592_speedRate { get; set; } = 1.45f; 

    [JsonPropertyName("wp2592_emergencyAddSpeedRate_")]
    public float Wp2592_emergencyAddSpeedRate { get; set; } = 0.5f; 

    [JsonPropertyName("wp2590_aliveTime_")]
    public float Wp2590_aliveTime { get; set; } = 30f; 

    [JsonPropertyName("wp2590_shotInterval_")]
    public float Wp2590_shotInterval { get; set; } = 1.5f; 

    [JsonPropertyName("wp2590_shotInterval_fast_")]
    public float Wp2590_shotInterval_fast { get; set; } = 0.5f; 

    [JsonPropertyName("wp2592_followTiltMax_")]
    public float Wp2592_followTiltMax { get; set; } = 7f; 

    [JsonPropertyName("wp2592_deleteTime_")]
    public float Wp2592_deleteTime { get; set; } = 0.5f; 

    [JsonPropertyName("wp2592_healRate_")]
    public float Wp2592_healRate { get; set; } = 0.1f; 

    [JsonPropertyName("wp2592_healLimit_")]
    public float Wp2592_healLimit { get; set; } = 7000f; 

    [JsonPropertyName("wp2592_barrierLimit_")]
    public float Wp2592_barrierLimit { get; set; } = 10000f; 

    [JsonPropertyName("isActiveSpArtsCorrection_")]
    public bool IsActiveSpArtsCorrection { get; set; } = true; 

    [JsonPropertyName("spartsGageRate_1st_move_")]
    public float SpartsGageRate_1st_move { get; set; } = 0.6f; 

    [JsonPropertyName("spartsGageRate_1st_stay_")]
    public float SpartsGageRate_1st_stay { get; set; } = 0.6f; 

    [JsonPropertyName("spartsGageRate_2nd_move_")]
    public float SpartsGageRate_2nd_move { get; set; } = 0.13f; 

    [JsonPropertyName("spartsGageRate_2nd_stay_")]
    public float SpartsGageRate_2nd_stay { get; set; } = 0.13f; 

    [JsonPropertyName("spartsGageRate_3rd_move_")]
    public float SpartsGageRate_3rd_move { get; set; } = 0.21f; 

    [JsonPropertyName("spartsGageRate_3rd_stay_")]
    public float SpartsGageRate_3rd_stay { get; set; } = 0.21f; 

    [JsonPropertyName("spartsGageRate_ability4_")]
    public float SpartsGageRate_ability4 { get; set; } = 0.3f; 

    [JsonPropertyName("spartsGageRate_ability5_")]
    public float SpartsGageRate_ability5 { get; set; } = 0.15f; 

    [JsonPropertyName("spartsGageRate_normalAttack_1st_")]
    public float SpartsGageRate_normalAttack_1st { get; set; } = 0.09999999f; 

    [JsonPropertyName("spartsGageRate_normalAttack_2nd_")]
    public float SpartsGageRate_normalAttack_2nd { get; set; } = 0.09999999f; 

    [JsonPropertyName("spartsGageRate_normalAttack_3rd_")]
    public float SpartsGageRate_normalAttack_3rd { get; set; } = 0.165f; 

    [JsonPropertyName("spartsGageRate_upperAttack_")]
    public float SpartsGageRate_upperAttack { get; set; } = 0.2f; 

    [JsonPropertyName("spartsGageRate_fallAttack_")]
    public float SpartsGageRate_fallAttack { get; set; } = 0.25f; 

    [JsonPropertyName("spartsGageRate_airAttack_1st_")]
    public float SpartsGageRate_airAttack_1st { get; set; } = 0.17f; 

    [JsonPropertyName("spartsGageRate_airAttack_2nd_")]
    public float SpartsGageRate_airAttack_2nd { get; set; } = 0.145f; 

    [JsonPropertyName("spartsGageRate_airAttack_3rd_")]
    public float SpartsGageRate_airAttack_3rd { get; set; } = 0.115f; 

    public Pl2500Param()
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
        IsSetExtraWeaponMotion = true;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class WeaponMeshControlParam /* Pl2500Param::WeaponMeshControlParam */
    {
        [JsonPropertyName("isGuardDummy_")]
        public bool IsGuardDummy { get; set; } 
    
        [JsonPropertyName("isAppearance_")]
        public bool IsAppearance { get; set; } 
    
        [JsonPropertyName("isCallVfx_")]
        public bool IsCallVfx { get; set; } 
    
        [JsonPropertyName("keyAnimName_")]
        public string? KeyAnimName { get; set; }

        [JsonPropertyName("keyPartsNumList_")]
        public BindingList<int> KeyPartsNumList { get; set; } = []; // std::vector<int> 

        [JsonPropertyName("delayFrame_")]
        public int DelayFrame { get; set; } 
    
        [JsonPropertyName("repeatCount_")]
        public int RepeatCount { get; set; } 
    
        [JsonPropertyName("vfxRepeatCount_")]
        public int VfxRepeatCount { get; set; } 
    
        [JsonPropertyName("vfxId_")]
        public int VfxId { get; set; }
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Wp2500SwordEmissiveParam
{
    [JsonPropertyName("emissives_")]
    [Editable(false)]
    public BindingList<EmissivePair> Emissives { get; set; } = [..Enumerable.Repeat(new EmissivePair(), 4)]; // std::array<Wp2500SwordEmissiveParam::EmissivePair,4>

    [JsonPropertyName("phaseEmissives_")]
    public BindingList<EmissivePhaseData> PhaseEmissives { get; set; } = []; // std::vector<Wp2500SwordEmissiveParam::EmissivePhaseData>

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Emissive /* Wp2500SwordEmissiveParam::Emissive */
    {
        [JsonPropertyName("color_")]
        [Editable(false)]
        public BindingList<Vector3> Color { get; set; } = [.. Enumerable.Repeat(Vector3.Zero, 2)]; // std::array<float,4>

        [JsonPropertyName("intensity_")]
        [Editable(false)]
        public BindingList<float> Intensity { get; set; } = [.. Enumerable.Repeat(0, 2)]; // std::array<float,2>

        [JsonPropertyName("useEmissiveAnim_")]
        public bool UseEmissiveAnim { get; set; } 
    
        [JsonPropertyName("blinkTime_")]
        public float BlinkTime { get; set; }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EmissivePair /* Wp2500SwordEmissiveParam::EmissivePair */
    {
        [JsonPropertyName("emissive_")]
        public Emissive Emissive { get; set; } = new();

        [JsonPropertyName("emissiveHold_")]
        public Emissive EmissiveHold { get; set; } = new();
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class EmissivePhaseData /* Wp2500SwordEmissiveParam::EmissivePhaseData */
    {
        [JsonPropertyName("emissivePairArray_")]
        [Editable(false)]
        public BindingList<EmissivePair> EmissivePairArray { get; set; } = [.. Enumerable.Repeat(new EmissivePair(), 4)]; // std::array<Wp2500SwordEmissiveParam::EmissivePair,4>

        [JsonPropertyName("adaptPhaseArray_")]
        public BindingList<int> AdaptPhaseArray { get; set; } = []; // std::vector<int>
    }
}