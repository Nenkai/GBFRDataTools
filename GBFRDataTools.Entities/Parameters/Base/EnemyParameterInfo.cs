using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Numerics;
using GBFRDataTools.Entities.Base;
using System.ComponentModel;

namespace GBFRDataTools.Entities.Parameters.Base;

public class EnemyParameterInfo : CharaParameterBase
{
    [JsonPropertyName("hateRateClosePlayer_")]
    public int HateRateClosePlayer { get; set; }

    [JsonPropertyName("hateRateFarPlayer_")]
    public int HateRateFarPlayer { get; set; }

    [JsonPropertyName("hateRateClosePlayerPerSec_")]
    public int HateRateClosePlayerPerSec { get; set; }

    [JsonPropertyName("hateRateFarPlayerPerSec_")]
    public int HateRateFarPlayerPerSec { get; set; }

    [JsonPropertyName("hateRateFrontAngle_")]
    public int HateRateFrontAngle { get; set; }

    [JsonPropertyName("hateRateBackAngle_")]
    public int HateRateBackAngle { get; set; }

    [JsonPropertyName("hateRateDamage_")]
    public int HateRateDamage { get; set; }

    [JsonPropertyName("hateRateManualPlayer_")]
    public int HateRateManualPlayer { get; set; }

    [JsonPropertyName("hateRateHighHpPlayer_")]
    public int HateRateHighHpPlayer { get; set; }

    [JsonPropertyName("hateRateLowHpPlayer_")]
    public int HateRateLowHpPlayer { get; set; }

    [JsonPropertyName("hateRateTargetCountManyPlayer_")]
    public int HateRateTargetCountManyPlayer { get; set; }

    [JsonPropertyName("hateRateTargetCountFewPlayer_")]
    public int HateRateTargetCountFewPlayer { get; set; }

    [JsonPropertyName("hateRateHelpPlayer_")]
    public int HateRateHelpPlayer { get; set; }

    [JsonPropertyName("hateRateLastTargetPlayer_")]
    public int HateRateLastTargetPlayer { get; set; }

    [JsonPropertyName("hateRateFirstTargetPlayer_")]
    public int HateRateFirstTargetPlayer { get; set; }

    [JsonPropertyName("badStatusHateRateMap_")]
    public int[] BadStatusHateRateMap { get; set; } // map<int, uint>?

    [JsonPropertyName("hateUpdateTime_")]
    public float HateUpdateTime { get; set; }

    [JsonPropertyName("damageToHateRate_")]
    public float DamageToHateRate { get; set; }

    [JsonPropertyName("damageHateDecPerSec_")]
    public float DamageHateDecPerSec { get; set; }

    [JsonPropertyName("closeHateIncRate_")]
    public float CloseHateIncRate { get; set; }

    [JsonPropertyName("closeHateDecRate_")]
    public float CloseHateDecRate { get; set; }

    [JsonPropertyName("farHateIncRate_")]
    public float FarHateIncRate { get; set; }

    [JsonPropertyName("farHateDecRate_")]
    public float FarHateDecRate { get; set; }

    [JsonPropertyName("combatPower_")]
    public int CombatPower { get; set; }

    [JsonPropertyName("combatPowerList_")]
    public int[] CombatPowerList { get; set; } = new int[4]; // std::array<int,4>>

    [JsonPropertyName("itemRewordMoneyVal_")]
    public int ItemRewordMoneyVal { get; set; }

    [JsonPropertyName("itemRewordJumpRate_")]
    public float ItemRewordJumpRate { get; set; }

    [JsonPropertyName("battle2SearchLength_")]
    public float Battle2SearchLength { get; set; }

    [JsonPropertyName("search2battleLength_")]
    public float Search2battleLength { get; set; }

    [JsonPropertyName("enemySize_")]
    public int EnemySize { get; set; }

    [JsonPropertyName("linkAttackCameraDistRate_")]
    public float LinkAttackCameraDistRate { get; set; }

    [JsonPropertyName("targetRangeParam_")]
    public TargetRangeParam TargetRangeParam_ { get; set; }

    [JsonPropertyName("counterAttackParam_")]
    public CounterAttackParam CounterAttackParam_ { get; set; }

    [JsonPropertyName("counterAttackParams_")]
    public CounterAttackParam[] CounterAttackParams { get; set; } = new CounterAttackParam[4]; // std::array<CounterAttackParam,4>

    [JsonPropertyName("useCounterAttackParam_")]
    public bool[] UseCounterAttackParam { get; set; } = new bool[4]; // std::array<bool,4>

    [JsonPropertyName("badStatusResistanceParams_")]
    public BadStatusResistanceParam[] BadStatusResistanceParams { get; set; } = new BadStatusResistanceParam[9]; // std::array<EnemyParameterInfo::BadStatusResistanceParam,9>

    [JsonPropertyName("statusParams_")]
    public EmStatusParams StatusParams { get; set; } = new();

    [JsonPropertyName("cameraCollisionParams_")]
    public List<CameraCollisionParam> CameraCollisionParams { get; set; } = []; // std::vector<EnemyParameterInfo::CameraCollisionParam>

    [JsonPropertyName("linkParam_")]
    public EmLinkAttackParam LinkParam { get; set; } = new(); // ss::reflection::StructAttribute<EnemyParameterInfo,EmLinkAttackParam>

    [JsonPropertyName("lockOnParam_")]
    public EmLockOnParam LockOnParam { get; set; } = new(); // ss::reflection::StructAttribute<EnemyParameterInfo,EmLockOnParam>

    [JsonPropertyName("collisionParam_")]
    public CharaCollisionParam CollisionParam { get; set; } = new(); // ss::reflection::StructAttribute<EnemyParameterInfo,CharaCollisionParam>

    [JsonPropertyName("animInterDefaultSec_")]
    public float AnimInterDefaultSec { get; set; }

    [JsonPropertyName("damageAnimInterDefaultSec_")]
    public float DamageAnimInterDefaultSec { get; set; }

    [JsonPropertyName("uiPartsNo_")]
    public int UiPartsNo { get; set; }

    [JsonPropertyName("uiOffsetY_")]
    public float UiOffsetY { get; set; }

    [JsonPropertyName("basicHitStopTimeRate_")]
    public float BasicHitStopTimeRate { get; set; }

    [JsonPropertyName("damageReactionHitStopTimeRate_")]
    public float DamageReactionHitStopTimeRate { get; set; }

    [JsonPropertyName("superArmorHitStopTimeRate_")]
    public float SuperArmorHitStopTimeRate { get; set; }

    [JsonPropertyName("attackerHitStopTimeRate_")]
    public float AttackerHitStopTimeRate { get; set; }

    [JsonPropertyName("addReactionHitstopFrameMin_")]
    public float AddReactionHitstopFrameMin { get; set; }

    [JsonPropertyName("addReactionHitstopFrameMax_")]
    public float AddReactionHitstopFrameMax { get; set; }

    [JsonPropertyName("addReactionWeightRateMin_")]
    public float AddReactionWeightRateMin { get; set; }

    [JsonPropertyName("addReactionWeightRateMax_")]
    public float AddReactionWeightRateMax { get; set; }

    [JsonPropertyName("addReactionWeightRateAI_")]
    public float AddReactionWeightRateAI { get; set; }

    [JsonPropertyName("addReactionInterSec_")]
    public float AddReactionInterSec { get; set; }

    [JsonPropertyName("isEyeLookingAtLockOn_")]
    public bool IsEyeLookingAtLockOn { get; set; }

    [JsonPropertyName("lookingAtPartsNo_")]
    public int LookingAtPartsNo { get; set; }

    [JsonPropertyName("isEnableSyncWeaponAnim_")]
    public bool IsEnableSyncWeaponAnim { get; set; }

    [JsonPropertyName("weakPointParam_")]
    public EmWeakPointParam WeakPointParam { get; set; }

    [JsonPropertyName("defenseTargetHateParams_")]
    public EmDefenseTargetHateParam[] DefenseTargetHateParams { get; set; } = new EmDefenseTargetHateParam[4]; // std::array<EmDefenseTargetHateParam,4>

    [JsonPropertyName("ignoreAilments_")]
    public BindingList<uint> IgnoreAilments { get; set; } = []; // std::vector<unsigned int>

    [JsonPropertyName("stageInvisibleStartDistance_")]
    public float StageInvisibleStartDistance { get; set; }

    [JsonPropertyName("stageInvisibleEndDistance_")]
    public float StageInvisibleEndDistance { get; set; }

    [JsonPropertyName("neckCtrlParam_")]
    public EmNeckCtrlParam NeckCtrlParam { get; set; } = new(); // ss::reflection::StructAttribute<EnemyParameterInfo,EmNeckCtrlParam>

    [JsonPropertyName("isChangeNormalDamageAttackReaction_")]
    public bool IsChangeNormalDamageAttackReaction { get; set; }

    [JsonPropertyName("isUseNormalDamageAttackReactionDefault_")]
    public bool IsUseNormalDamageAttackReactionDefault { get; set; }

    [JsonPropertyName("normalDamageAttackReaction_")]
    public ushort[] NormalDamageAttackReaction { get; set; } = new ushort[26]; // std::array<unsigned short,26>

    [JsonPropertyName("isCallExplodeBodyPresageDefaultVfx_")]
    public bool IsCallExplodeBodyPresageDefaultVfx { get; set; }

    [JsonPropertyName("isDisableAerialDownReaction_")]
    public bool IsDisableAerialDownReaction { get; set; }

    public class TargetRangeParam // EnemyParameterInfo::TargetRangeParam
    {
        [JsonPropertyName("rangeClose_")]
        public float RangeClose { get; set; }

        [JsonPropertyName("rangeShort_")]
        public float RangeShort { get; set; }

        [JsonPropertyName("rangeMiddle_")]
        public float RangeMiddle { get; set; }

        [JsonPropertyName("rangeLong_")]
        public float RangeLong { get; set; }
    }

    public class CounterAttackParam // EnemyParameterInfo::CounterAttackParam
    {
        [JsonPropertyName("damageMaxValue_")]
        public int DamageMaxValue { get; set; }

        [JsonPropertyName("damageMinValue_")]
        public int DamageMinValue { get; set; }

        [JsonPropertyName("reduceDamageValueInSec_")]
        public int ReduceDamageValueInSec { get; set; }

        [JsonPropertyName("stopReduceTime_")]
        public float StopReduceTime { get; set; }

        [JsonPropertyName("coolTime_")]
        public float CoolTime { get; set; }

        [JsonPropertyName("onceCheckCounterAttack_")]
        public bool OnceCheckCounterAttack { get; set; }

        [JsonPropertyName("isReferenceMaxHpRate_")]
        public bool IsReferenceMaxHpRate { get; set; }
    }

    public class BadStatusResistanceParam // EnemyParameterInfo::BadStatusResistanceParam
    {
        [JsonPropertyName("maxValue_")]
        public float MaxValue { get; set; }

        [JsonPropertyName("minValue_")]
        public float MinValue { get; set; }

        [JsonPropertyName("subValue_")]
        public float SubValue { get; set; }

        [JsonPropertyName("coolTime_")]
        public float CoolTime { get; set; }

        [JsonPropertyName("regeneValue_")]
        public float RegeneValue { get; set; }

        [JsonPropertyName("startStopTime_")]
        public float StartStopTime { get; set; }
    }

    public class EmStatusParams // EnemyParameterInfo::EmStatusParams
    {
        [JsonPropertyName("regeneratePercent_")]
        public float RegeneratePercent { get; set; }

        [JsonPropertyName("regenerateCycleSec_")]
        public float RegenerateCycleSec { get; set; }

        [JsonPropertyName("multiAttackNum_")]
        public int MultiAttackNum { get; set; }

        [JsonPropertyName("multiAttackDelayFrame_")]
        public int MultiAttackDelayFrame { get; set; }

        [JsonPropertyName("multiAttackAtkRate_")]
        public float MultiAttackAtkRate { get; set; }

        [JsonPropertyName("multiAttackHitStopDivision_")]
        public float MultiAttackHitStopDivision { get; set; }

        [JsonPropertyName("burnDotDamageLimitRate_")]
        public float BurnDotDamageLimitRate { get; set; }

        [JsonPropertyName("poisonDotDamageLimitRate_")]
        public float PoisonDotDamageLimitRate { get; set; }

        [JsonPropertyName("dimentionDotDamageLimitRate_")]
        public float DimentionDotDamageLimitRate { get; set; }
    }

    public class CameraCollisionParam
    {
        [JsonPropertyName("type_")]
        public int Type { get; set; }

        [JsonPropertyName("scale_")]
        public /* cVec4 */ Vector4 Scale { get; set; }

        [JsonPropertyName("offset_")]
        public /* cVec4 */ Vector4 Offset { get; set; }

        [JsonPropertyName("partsNo_")]
        public int PartsNo { get; set; }
    }
}
