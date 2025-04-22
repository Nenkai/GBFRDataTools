using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7000;

public class Em7001Param : EmBossBaseParam
{
    [JsonPropertyName("aiLevelParams_")]
    [Editable(false)]
    public BindingList<AILevelParam> AiLevelParams { get; set; } = [.. Enumerable.Repeat(new AILevelParam(), 5)];

    [JsonPropertyName("phaseChangeParams_")]
    [Editable(false)]
    public BindingList<PhaseChangeParam> PhaseChangeParams { get; set; } = [.. Enumerable.Repeat(new PhaseChangeParam(), 3)];

    [JsonPropertyName("overdriveParams_")]
    [Editable(false)]
    public BindingList<OverDriveParam> OverdriveParams { get; set; } = [.. Enumerable.Repeat(new OverDriveParam(), 4)];

    [JsonPropertyName("flightParam_")]
    public Em7001FlightParam FlightParam { get; set; }

    [JsonPropertyName("flyMovePassParam_")]
    public Em7001MovePassListParam FlyMovePassParam { get; set; }

    [JsonPropertyName("moveBlendAnimParam_")]
    public Em7001MoveBlendAnimParam MoveBlendAnimParam { get; set; }

    [JsonPropertyName("returnMovePassListParam_")]
    public Em7001MovePassListParam ReturnMovePassListParam { get; set; }

    [JsonPropertyName("gunSeatAtkRate_")]
    public float GunSeatAtkRate { get; set; } = 1f;

    [JsonPropertyName("nearBreakDistX_")]
    public float NearBreakDistX { get; set; } = 65f;

    [JsonPropertyName("linkAttackAddDist_")]
    public float LinkAttackAddDist { get; set; } = 8f;

    [JsonPropertyName("linkBreakChanceDist_")]
    public float LinkBreakChanceDist { get; set; } = 30f;

    [JsonPropertyName("attributeDownReactionDelaySec_")]
    public float AttributeDownReactionDelaySec { get; set; } = 1.5f;

    [JsonPropertyName("fireCoreSummonParams_")]
    [Editable(false)]
    public BindingList<Em7001CoreSummonParam> FireCoreSummonParams { get; set; } = [.. Enumerable.Repeat(new Em7001CoreSummonParam(), 3)];

    [JsonPropertyName("waterCoreSummonParams_")]
    [Editable(false)]
    public BindingList<Em7001CoreSummonParam> WaterCoreSummonParams { get; set; } = [.. Enumerable.Repeat(new Em7001CoreSummonParam(), 3)];

    [JsonPropertyName("earthCoreSummonParams_")]
    [Editable(false)]
    public BindingList<Em7001CoreSummonParam> EarthCoreSummonParams { get; set; } = [.. Enumerable.Repeat(new Em7001CoreSummonParam(), 3)];

    [JsonPropertyName("windCoreSummonParams_")]
    [Editable(false)]
    public BindingList<Em7001CoreSummonParam> WindCoreSummonParams { get; set; } = [.. Enumerable.Repeat(new Em7001CoreSummonParam(), 3)];

    [JsonPropertyName("coreOffsetPosParam_")]
    public Em7001CoreOffsetPosParam CoreOffsetPosParam { get; set; }

    [JsonPropertyName("addDamage1stParam_")]
    public EmAddDamageParam AddDamage1stParam { get; set; }

    [JsonPropertyName("addDamage2ndParam_")]
    public EmAddDamageParam AddDamage2ndParam { get; set; }

    [JsonPropertyName("phase1IdlePosParam_")]
    public Em7001PositionParam Phase1IdlePosParam { get; set; }

    [JsonPropertyName("phase1BeforeCatastrophePosParam_")]
    public Em7001PositionParam Phase1BeforeCatastrophePosParam { get; set; }

    [JsonPropertyName("phase2RightIdlePosParam_")]
    public Em7001PositionParam Phase2RightIdlePosParam { get; set; }

    [JsonPropertyName("phase2LeftIdlePosParam_")]
    public Em7001PositionParam Phase2LeftIdlePosParam { get; set; }

    [JsonPropertyName("phase2RightSupernovaPosParam_")]
    public Em7001PositionParam Phase2RightSupernovaPosParam { get; set; }

    [JsonPropertyName("phase2LeftSupernovaPosParam_")]
    public Em7001PositionParam Phase2LeftSupernovaPosParam { get; set; }

    [JsonPropertyName("phase2RightFrontDeckDamagePosParam_")]
    public Em7001PositionParam Phase2RightFrontDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase2RightBackDeckDamagePosParam_")]
    public Em7001PositionParam Phase2RightBackDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase2RightDeckDamagePosParam_")]
    public Em7001PositionParam Phase2RightDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase2LeftFrontDeckDamagePosParam_")]
    public Em7001PositionParam Phase2LeftFrontDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase2LeftBackDeckDamagePosParam_")]
    public Em7001PositionParam Phase2LeftBackDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase2LeftDeckDamagePosParam_")]
    public Em7001PositionParam Phase2LeftDeckDamagePosParam { get; set; }

    [JsonPropertyName("phase4IdlePosParam_")]
    public Em7001PositionParam Phase4IdlePosParam { get; set; }

    [JsonPropertyName("rightOnlySpArtsWarpPosParams_")]
    public Em7001PositionListParam RightOnlySpArtsWarpPosParams { get; set; }

    [JsonPropertyName("freeSpArtsWarpPosParams_")]
    public Em7001PositionListParam FreeSpArtsWarpPosParams { get; set; }

    [JsonPropertyName("frontOnlySpArtsWarpPosParam_")]
    public Em7001PositionParam FrontOnlySpArtsWarpPosParam { get; set; }

    [JsonPropertyName("rightOnlySpArtsChainBurstPosParams_")]
    public Em7001PositionListParam RightOnlySpArtsChainBurstPosParams { get; set; }

    [JsonPropertyName("freeSpArtsChainBurstPosParams_")]
    public Em7001PositionListParam FreeSpArtsChainBurstPosParams { get; set; }

    [JsonPropertyName("frontOnlySpArtsChainBurstPosParam_")]
    public Em7001PositionParam FrontOnlySpArtsChainBurstPosParam { get; set; }

    [JsonPropertyName("coreEnegryPosParam_")]
    public Em7001PositionParam CoreEnegryPosParam { get; set; }

    [JsonPropertyName("rideDeckParam_")]
    public Em7001RideDeckParam RideDeckParam { get; set; }

    [JsonPropertyName("superReginRaveParam_")]
    public Em7001SuperReginRaveParam SuperReginRaveParam { get; set; }

    [JsonPropertyName("superNovaParam_")]
    public Em7001SuperNovaParam SuperNovaParam { get; set; }

    [JsonPropertyName("posAdjustEaseParam_")]
    public EaseParam PosAdjustEaseParam { get; set; }

    [JsonPropertyName("catastrapheParam_")]
    public Em7001CatastropheParam CatastrapheParam { get; set; }

    [JsonPropertyName("spArtsCatastrapheParam_")]
    public Em7001CatastropheParam SpArtsCatastrapheParam { get; set; }

    [JsonPropertyName("actionCommandParam_")]
    public Em7001ActionCommandParam ActionCommandParam { get; set; }

    [JsonPropertyName("animRateParam_")]
    public Em7001AnimRateParam AnimRateParam { get; set; }

    [JsonPropertyName("downReactionAnimAdjustPosParam_")]
    public Em7001AnimAdjustPosParam DownReactionAnimAdjustPosParam { get; set; }

    [JsonPropertyName("tackleParam_")]
    public Em7001TackleParam TackleParam { get; set; }

    [JsonPropertyName("rideDeckReginRaveParam_")]
    public Em7001RideDeckReginRaveParam RideDeckReginRaveParam { get; set; }

    [JsonPropertyName("clawBeamParam_")]
    public Em7001ClawBeamParam ClawBeamParam { get; set; }

    [JsonPropertyName("shockWaveParam_")]
    public Em7001ShockWaveParam ShockWaveParam { get; set; }

    [JsonPropertyName("grandcypherCenterPosParam_")]
    public Em7001PositionParam GrandcypherCenterPosParam { get; set; }

    [JsonPropertyName("ragnarokFiledAttackParam_")]
    public Em7001WideAreaShotParam RagnarokFiledAttackParam { get; set; }

    [JsonPropertyName("magicCircleCommonParam_")]
    public Em7001MagicCircleCommonParam MagicCircleCommonParam { get; set; }

    [JsonPropertyName("clawShockWaveParams_")]
    [Editable(false)]
    public BindingList<Em7001ClawShockWaveParam> ClawShockWaveParams { get; set; } = [.. Enumerable.Repeat(new Em7001ClawShockWaveParam(), 3)]; // std::array<Em7001ClawShockWaveParam,3>

    [JsonPropertyName("laserParam_")]
    public Em7001LaserParam LaserParam { get; set; }

    [JsonPropertyName("weakPointBreakRate_")]
    public float WeakPointBreakRate { get; set; } = 1.5f;

    [JsonPropertyName("attackAreaParams_")]
    [Editable(false)]
    public BindingList<Em7001AttackAreaParam> AttackAreaParams { get; set; } = [.. Enumerable.Repeat(new Em7001AttackAreaParam(), 6)];

    [JsonPropertyName("lockOnSetParams_")]
    [Editable(false)]
    public BindingList<EmLockOnParam> LockOnSetParams { get; set; } = [.. Enumerable.Repeat(new EmLockOnParam(), 8)];

    [JsonPropertyName("lowHpRate_")]
    public float LowHpRate { get; set; } = 0.35f;

    [JsonPropertyName("cameraParam_")]
    public Em7001CameraParam CameraParam { get; set; }

    [JsonPropertyName("etherCannonParam_")]
    public Em7001EtherCannonParam EtherCannonParam { get; set; }

    [JsonPropertyName("partsBreakParam_")]
    public Em7001PartsBreakParam PartsBreakParam { get; set; }

    [JsonPropertyName("forcedDefeatParam_")]
    public Em7001ForcedDefeatParam ForcedDefeatParam { get; set; }

    [JsonPropertyName("lightShotDamageHitScale_")]
    public float LightShotDamageHitScale { get; set; } = 4.8f;

    [JsonPropertyName("ragnarokShotDamageHitScale_")]
    public float RagnarokShotDamageHitScale { get; set; } = 8f;

    [JsonPropertyName("superBahamutEmissiveInitValue_")]
    public float SuperBahamutEmissiveInitValue { get; set; } = 0.35f;

    [JsonPropertyName("superBahamutEmissiveParamDefault_")]
    public CharacterEmissiveParam SuperBahamutEmissiveParamDefault { get; set; }

    [JsonPropertyName("superBahamutEmissiveParamMax_")]
    public CharacterEmissiveParam SuperBahamutEmissiveParamMax { get; set; }

    [JsonPropertyName("superBahamutEmissiveParamMin_")]
    public CharacterEmissiveParam SuperBahamutEmissiveParamMin { get; set; }

    [JsonPropertyName("addDamageMotionPlayFrame_")]
    public int AddDamageMotionPlayFrame { get; set; } = 30;

    [JsonPropertyName("enableLockOnLength_")]
    public float EnableLockOnLength { get; set; } = 500f;

    [JsonPropertyName("nearTargetOffsetPos_")]
    public Vector4 NearTargetOffsetPos { get; set; } = new Vector4(0f, 2f, 0f, 1f);

    [JsonPropertyName("nearCameraOffsetRotX_")]
    public float NearCameraOffsetRotX { get; set; } = -5f;

    [JsonPropertyName("targetOffsetPos_")]
    public Vector4 TargetOffsetPos { get; set; } = new Vector4(0f, 1f, 0f, 1f);

    [JsonPropertyName("lockOnCameraOffsetRotX_")]
    public float LockOnCameraOffsetRotX { get; set; } = -2f;

    [JsonPropertyName("downReactionOverrideMotParams_")]
    [Editable(false)]
    public BindingList<Em7001DownReactionMotParam> DownReactionOverrideMotParams { get; set; } = [.. Enumerable.Repeat(new Em7001DownReactionMotParam(), 2)]; // std::array<Em7001DownReactionMotParam,2>

    [JsonPropertyName("frontDeckAlphaPosParam_")]
    public Em7001PositionParam FrontDeckAlphaPosParam { get; set; }

    [JsonPropertyName("frontDeckAlphaAreaSize_")]
    public Vector3 FrontDeckAlphaAreaSize { get; set; } = new Vector3(17f, 40f, 22f);

    [JsonPropertyName("rightRideDeckDefaultLockOnOffsetParam_")]
    public Em7001PositionParam RightRideDeckDefaultLockOnOffsetParam { get; set; }

    [JsonPropertyName("rightRideDeckHeadLockOnOffsetParam_")]
    public Em7001PositionParam RightRideDeckHeadLockOnOffsetParam { get; set; }

    [JsonPropertyName("rightRideDeckRHandLockOnOffsetParam_")]
    public Em7001PositionParam RightRideDeckRHandLockOnOffsetParam { get; set; }

    [JsonPropertyName("rightRideDeckLHandLockOnOffsetParam_")]
    public Em7001PositionParam RightRideDeckLHandLockOnOffsetParam { get; set; }

    [JsonPropertyName("leftRideDeckDefaultLockOnOffsetParam_")]
    public Em7001PositionParam LeftRideDeckDefaultLockOnOffsetParam { get; set; }

    [JsonPropertyName("leftRideDeckHeadLockOnOffsetParam_")]
    public Em7001PositionParam LeftRideDeckHeadLockOnOffsetParam { get; set; }

    [JsonPropertyName("leftRideDeckRHandLockOnOffsetParam_")]
    public Em7001PositionParam LeftRideDeckRHandLockOnOffsetParam { get; set; }

    [JsonPropertyName("leftRideDeckLHandLockOnOffsetParam_")]
    public Em7001PositionParam LeftRideDeckLHandLockOnOffsetParam { get; set; }

    public Em7001Param()
    {
        Hp = 100000;
        Atk = 10;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 0;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 10f;
        DamageToHateRate = 0.02f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 1f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.5f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
        CameraLength = 8.5f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AILevelParam
    {
        [JsonPropertyName("attributeAttackSec_")]
        public float AttributeAttackSec { get; set; } // Offset 0x10

        [JsonPropertyName("reactionGaugeParam_")]
        public Em7001ReactionGaugeParam ReactionGaugeParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("fireAttributeAtkParam_")]
        public Em7001WideAreaShotParam FireAttributeAtkParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("waterAttributeAtkParam_")]
        public Em7001WideAreaShotParam WaterAttributeAtkParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("earthAttributeAtkParam_")]
        public Em7001WideAreaShotParam EarthAttributeAtkParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("windAttributeAtkParam_")]
        public Em7001WideAreaShotParam WindAttributeAtkParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("frontCatastropheParam_")]
        public Em7001FrontCatastropheParam FrontCatastropheParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("ragnarokFieldParam_")]
        public Em7001RagnarokFieldParam RagnarokFieldParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("darkCoreSummonParam_")]
        public Em7001DarkCoreSummonParam DarkCoreSummonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("dpsCheckDarkCoreSummonParam_")]
        public Em7001DarkCoreSummonParam DpsCheckDarkCoreSummonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("tackleCoreSummonParam_")]
        public Em7001CoreSummonParam TackleCoreSummonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("rideBeginCoreSummonParam_")]
        public Em7001CoreSummonParam RideBeginCoreSummonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("rideEndCoreSummonParam_")]
        public Em7001CoreSummonParam RideEndCoreSummonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBulletCommonParam_")]
        public Em7001LightBulletCommonParam LightBulletCommonParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBulletExplosionGroupParam_")]
        public Em7001LightShotExplosionGroupParam LightBulletExplosionGroupParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("redLightShotAttackParam_")]
        public Em7001RedLightShotAttackParam RedLightShotAttackParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBullet1st_")]
        public Em7001LightBulletActionParam LightBullet1st { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBullet2nd_")]
        public Em7001LightBulletActionParam LightBullet2nd { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBullet3rd_")]
        public Em7001LightBulletActionParam LightBullet3rd { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("lightBullet3rdOD_")]
        public Em7001LightBulletActionParam LightBullet3rdOD { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("damageLightBulletGroupParam_")]
        public Em7001LightBulletGroupParam DamageLightBulletGroupParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("tackleLightBulletGroupParam_")]
        public Em7001LightBulletGroupParam TackleLightBulletGroupParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("flyLightBulletGroupParam_")]
        public Em7001FlyLightBulletActionParam FlyLightBulletGroupParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("shotPartsLightBulleParam_")]
        public Em7001LightBulletActionParam ShotPartsLightBulleParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("comboLightBulletGroupParams_")]
        [Editable(false)]
        public BindingList<Em7001LightBulletGroupParam> ComboLightBulletGroupParams { get; set; } = [.. Enumerable.Repeat(new Em7001LightBulletGroupParam(), 2)]; // Offset 0x808

        [JsonPropertyName("sideChangeBulletGroupParams_")]
        [Editable(false)]
        public BindingList<Em7001LightBulletGroupParam> SideChangeBulletGroupParams { get; set; } = [.. Enumerable.Repeat(new Em7001LightBulletGroupParam(), 3)]; // Offset 0x898

        [JsonPropertyName("fireCoreBattleTicketParam_")]
        public Em7001CoreBattleTicketParam FireCoreBattleTicketParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("waterCoreBattleTicketParam_")]
        public Em7001CoreBattleTicketParam WaterCoreBattleTicketParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("earthCoreBattleTicketParam_")]
        public Em7001CoreBattleTicketParam EarthCoreBattleTicketParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("windCoreBattleTicketParam_")]
        public Em7001CoreBattleTicketParam WindCoreBattleTicketParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("tackleWaitSec_")]
        public float TackleWaitSec { get; set; } // Offset 0xAA0

        [JsonPropertyName("downReactionParams_")]
        [Editable(false)]
        public BindingList<Em7001DownReactionParam> DownReactionParams { get; set; } = [..Enumerable.Repeat(new Em7001DownReactionParam(), 4)]; // std::array<Em7001DownReactionParam,4> - Offset 0x9C0

        [JsonPropertyName("dpsCheckWeakPointParam_")]
        public EmWeakPointParam DpsCheckWeakPointParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("darkCoreDarkFloorParam_")]
        public Em7001DarkFloorShotParam DarkCoreDarkFloorParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("magicCricleDarkFloorParam_")]
        public Em7001DarkFloorShotParam MagicCricleDarkFloorParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("attributeBuffParam_")]
        public Em7001AttributeBuffParam AttributeBuffParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("coreBarrierParam_")]
        public Em7001CoreBarrierParam CoreBarrierParam { get; set; } // Offset 0xCF543FFA

        public AILevelParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PhaseChangeParam
    {
        [JsonPropertyName("changePhaseHpRate_")]
        public float ChangePhaseHpRate { get; set; } // Offset 0x8

        public PhaseChangeParam()
        {
        }
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001PositionParam
{
    [JsonPropertyName("pos_")]
    public Vector4 Pos { get; set; } // Offset 0x10

    public Em7001PositionParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001WideAreaShotParam
{
    [JsonPropertyName("attackSignDispSec_")]
    public float AttackSignDispSec { get; set; } // Offset 0x10

    [JsonPropertyName("attackLifeSec_")]
    public float AttackLifeSec { get; set; } // Offset 0x14

    [JsonPropertyName("attackSize_")]
    public Vector4 AttackSize { get; set; } // Offset 0x20

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x30

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x34

    [JsonPropertyName("attackDirection_")]
    public int AttackDirection { get; set; } // Offset 0x38

    [JsonPropertyName("isFlipAtkDirBahamutPos_")]
    public bool IsFlipAtkDirBahamutPos { get; set; } // Offset 0x3C

    [JsonPropertyName("attackHitFlag_")]
    public ulong AttackHitFlag { get; set; } // unsigned __int64 - Offset 0x40

    [JsonPropertyName("multiHitIntervalSecond_")]
    public float MultiHitIntervalSecond { get; set; } // Offset 0x48

    [JsonPropertyName("reaction_")]
    public int Reaction { get; set; } // Offset 0x4C

    [JsonPropertyName("isScaleAttackSize_")]
    public bool IsScaleAttackSize { get; set; } // Offset 0x68

    [JsonPropertyName("scaleAttackSize_")]
    public Vector4 ScaleAttackSize { get; set; } // Offset 0x70

    [JsonPropertyName("scaleAttackSec_")]
    public float ScaleAttackSec { get; set; } // Offset 0x80

    [JsonPropertyName("isInHole_")]
    public bool IsInHole { get; set; } // Offset 0x84

    [JsonPropertyName("inHolePower_")]
    public float InHolePower { get; set; } // Offset 0x88

    [JsonPropertyName("hitPriority_")]
    public int HitPriority { get; set; } // Offset 0xBC

    [JsonPropertyName("isCreateAttackSign_")]
    public bool IsCreateAttackSign { get; set; } // Offset 0x9C

    [JsonPropertyName("vfxObjId_")]
    public int VfxObjId { get; set; } // Offset 0xD4

    [JsonPropertyName("vfxId_")]
    public int VfxId { get; set; } // Offset 0xD8

    [JsonPropertyName("transitionVfxActionEndSec_")]
    public float TransitionVfxActionEndSec { get; set; } // Offset 0xC0

    [JsonPropertyName("debuffData_")]
    public DebuffData DebuffData { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("attackPosParam_")]
    public Em7001PositionParam AttackPosParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("attackSignPosParam_")]
    public Em7001PositionParam AttackSignPosParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("isCamera_")]
    public bool IsCamera { get; set; } // Offset 0x8C

    [JsonPropertyName("cameraType_")]
    public int CameraType { get; set; } // Offset 0x90

    [JsonPropertyName("cameraSetSec_")]
    public float CameraSetSec { get; set; } // Offset 0x94

    [JsonPropertyName("cameraSetDisableSec_")]
    public float CameraSetDisableSec { get; set; } // Offset 0x98

    [JsonPropertyName("isChangeEffect_")]
    public bool IsChangeEffect { get; set; } // Offset 0x9D

    [JsonPropertyName("effectUseParentObjId_")]
    public bool EffectUseParentObjId { get; set; } // Offset 0x9E

    [JsonPropertyName("attackSignSize_")]
    public Vector4 AttackSignSize { get; set; } // Offset 0xA0

    [JsonPropertyName("effectBaseId_")]
    public int EffectBaseId { get; set; } // Offset 0xB0

    [JsonPropertyName("effectFillId_")]
    public int EffectFillId { get; set; } // Offset 0xB4

    [JsonPropertyName("effectVanishId_")]
    public int EffectVanishId { get; set; } // Offset 0xB8

    [JsonPropertyName("skillTextType_")]
    public int SkillTextType { get; set; } // Offset 0xDC

    [JsonPropertyName("skillTextShowWaitSec_")]
    public float SkillTextShowWaitSec { get; set; } // Offset 0xC4

    [JsonPropertyName("skillTextShowSec_")]
    public float SkillTextShowSec { get; set; } // Offset 0xC8

    [JsonPropertyName("isDestroyEtherCannonAll_")]
    public bool IsDestroyEtherCannonAll { get; set; } // Offset 0xCC

    [JsonPropertyName("destroyEtherCannonSec_")]
    public float DestroyEtherCannonSec { get; set; } // Offset 0xD0

    public Em7001WideAreaShotParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001RagnarokFieldParam
{
    [JsonPropertyName("bulletParamList_")]
    public BindingList<Em7001RagnarokBulletParam> BulletParamList { get; set; } = []; // std::vector<Em7001RagnarokBulletParam> - Offset 0x10

    [JsonPropertyName("trrigerSec_")]
    public float TrrigerSec { get; set; } // Offset 0x8

    public Em7001RagnarokFieldParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001RagnarokBulletParam
{
    [JsonPropertyName("hp_")]
    public int Hp { get; set; } // Offset 0x10

    [JsonPropertyName("posParam_")]
    public Em7001PositionParam PosParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("energyPosParam_")]
    public Em7001PositionParam EnergyPosParam { get; set; } // Offset 0xCF543FFA

    public Em7001RagnarokBulletParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ReactionGaugeParam
{
    [JsonPropertyName("falterReactionValue_")]
    public int FalterReactionValue { get; set; } // Offset 0x8

    [JsonPropertyName("damageReactionBigRate_")]
    public float DamageReactionBigRate { get; set; } // Offset 0xC

    [JsonPropertyName("smallBulletDamage_")]
    public int SmallBulletDamage { get; set; } // Offset 0x10

    [JsonPropertyName("bigBulletDamage_")]
    public int BigBulletDamage { get; set; } // Offset 0x14

    [JsonPropertyName("purpleLightShotDamage_")]
    public int PurpleLightShotDamage { get; set; } // Offset 0x18

    [JsonPropertyName("purpleLightShotJustDamage_")]
    public int PurpleLightShotJustDamage { get; set; } // Offset 0x1C

    [JsonPropertyName("redLightShotDamage_")]
    public int RedLightShotDamage { get; set; } // Offset 0x20

    [JsonPropertyName("redLightShotJustDamage_")]
    public int RedLightShotJustDamage { get; set; } // Offset 0x24

    public Em7001ReactionGaugeParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightBulletCommonParam
{
    [JsonPropertyName("lightBulletHp_")]
    public int LightBulletHp { get; set; } // Offset 0x8

    [JsonPropertyName("redLightBulletHp_")]
    public int RedLightBulletHp { get; set; } // Offset 0xC

    [JsonPropertyName("lightBombBastDamage_")]
    public int LightBombBastDamage { get; set; } // Offset 0x10

    [JsonPropertyName("lightJustBombBastDamage_")]
    public int LightJustBombBastDamage { get; set; } // Offset 0x14

    [JsonPropertyName("redLightBombBastDamage_")]
    public int RedLightBombBastDamage { get; set; } // Offset 0x18

    [JsonPropertyName("redLightJustBombBastDamage_")]
    public int RedLightJustBombBastDamage { get; set; } // Offset 0x1C

    [JsonPropertyName("chargeSec1st_")]
    public float ChargeSec1st { get; set; } // Offset 0x20

    [JsonPropertyName("chargeSec2nd_")]
    public float ChargeSec2nd { get; set; } // Offset 0x24

    [JsonPropertyName("chargeSec3rdOD_")]
    public float ChargeSec3rdOD { get; set; } // Offset 0x2C

    [JsonPropertyName("chargeSecShotParts_")]
    public float ChargeSecShotParts { get; set; } // Offset 0x30

    public Em7001LightBulletCommonParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightShotExplosionParam
{
    [JsonPropertyName("attackPower_")]
    public int AttackPower { get; set; } // Offset 0x8

    [JsonPropertyName("justDestoryAttackPower_")]
    public int JustDestoryAttackPower { get; set; } // Offset 0xC

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } // Offset 0x10

    [JsonPropertyName("explosionDeltySec_")]
    public float ExplosionDeltySec { get; set; } // Offset 0x14

    public Em7001LightShotExplosionParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightShotExplosionGroupParam
{
    [JsonPropertyName("lightShotExplosionParam_")]
    public Em7001LightShotExplosionParam LightShotExplosionParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("redLightShotExplosionParam_")]
    public Em7001LightShotExplosionParam RedLightShotExplosionParam { get; set; } // Offset 0xCF543FFA

    public Em7001LightShotExplosionGroupParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001RedLightShotAttackParam
{
    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } // Offset 0x8

    [JsonPropertyName("endRadius_")]
    public float EndRadius { get; set; } // Offset 0xC

    [JsonPropertyName("scalerSec_")]
    public float ScalerSec { get; set; } // Offset 0x10

    [JsonPropertyName("atkRate_")]
    public float AtkRate { get; set; } // Offset 0x14

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x18

    [JsonPropertyName("debuffListParam_")]
    public BindingList<DebuffData> DebuffListParam { get; set; } // std::vector<DebuffData> Offset 0x20

    public Em7001RedLightShotAttackParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CoreSummonParam
{
    [JsonPropertyName("summonType_")]
    public int SummonType { get; set; } // Offset 0x8

    [JsonPropertyName("summonNum_")]
    public int SummonNum { get; set; } // Offset 0xC

    [JsonPropertyName("summonNumMax_")]
    public int SummonNumMax { get; set; } // Offset 0x10

    [JsonPropertyName("summonCoreList_")]
    public BindingList<CoreInfo> SummonCoreList { get; set; } = []; // std::vector<Em7001CoreSummonParam::CoreInfo> - Offset 0x18

    public Em7001CoreSummonParam()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CoreInfo
    {
        [JsonPropertyName("modelType_")]
        public int ModelType { get; set; } // Offset 0x10

        [JsonPropertyName("posParam_")]
        public Em7001PositionParam PosParam { get; set; } // Offset 0xCF543FFA

        [JsonPropertyName("rotY_")]
        public float RotY { get; set; } // Offset 0x40

        [JsonPropertyName("isSetOnwerDir_")]
        public bool IsSetOnwerDir { get; set; } // Offset 0x44

        public CoreInfo()
        {
        }
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001DarkCoreSummonParam
{
    [JsonPropertyName("coreSummonParam_")]
    public Em7001CoreSummonParam CoreSummonParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("intervalSecMin_")]
    public float IntervalSecMin { get; set; } // Offset 0x38

    [JsonPropertyName("intervalSecMax_")]
    public float IntervalSecMax { get; set; } // Offset 0x3C

    public Em7001DarkCoreSummonParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightBulletActionParam
{
    [JsonPropertyName("lightBulletGroupParams_")]
    public BindingList<Em7001LightBulletGroupParam> LightBulletGroupParams { get; set; } = []; // std::vector<Em7001LightBulletGroupParam> - Offset 0x8

    public Em7001LightBulletActionParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightBulletListParam
{
    [JsonPropertyName("bulletList_")]
    public BindingList<Em7001LightBulletParam> BulletList { get; set; } = []; // Offset 0x8

    public Em7001LightBulletListParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightBulletGroupParam
{
    [JsonPropertyName("purpleLightBulletParam_")]
    public Em7001LightBulletListParam PurpleLightBulletParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("redLightBulletParam_")]
    public Em7001LightBulletListParam RedLightBulletParam { get; set; } // Offset 0xCF543FFA

    public Em7001LightBulletGroupParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LightBulletParam
{
    [JsonPropertyName("delaySec_")]
    public float DelaySec { get; set; } // Offset 0x10

    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } // Offset 0x14

    [JsonPropertyName("waitFireSec_")]
    public float WaitFireSec { get; set; } // Offset 0x18

    [JsonPropertyName("degZ_")]
    public float DegZ { get; set; } // Offset 0x1C

    [JsonPropertyName("speed_")]
    public float Speed { get; set; } // Offset 0x20

    [JsonPropertyName("pointHeight_")]
    public Vector2 PointHeight { get; set; } // Offset 0x24

    [JsonPropertyName("pointRate_")]
    public Vector2 PointRate { get; set; } // Offset 0x2C

    [JsonPropertyName("beginPos_")]
    public Em7001PositionParam BeginPos { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("endPos_")]
    public Em7001PositionParam EndPos { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("isEndPosTarget_")]
    public bool IsEndPosTarget { get; set; } // Offset 0x34

    [JsonPropertyName("isCreateAttackSign_")]
    public bool IsCreateAttackSign { get; set; } // Offset 0x35

    [JsonPropertyName("isAbsolutePos_")]
    public bool IsAbsolutePos { get; set; } // Offset 0x36

    [JsonPropertyName("attachPartsNo_")]
    public int AttachPartsNo { get; set; } // Offset 0x38

    public Em7001LightBulletParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001FlyLightBulletActionParam
{
    [JsonPropertyName("createInterval_")]
    public float CreateInterval { get; set; } // Offset 0x8

    [JsonPropertyName("lightBulletActionParam_")]
    public Em7001LightBulletActionParam LightBulletActionParam { get; set; } // Offset 0xCF543FFA

    public Em7001FlyLightBulletActionParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001FrontCatastropheParam
{
    [JsonPropertyName("chargeSec_")]
    public float ChargeSec { get; set; } // Offset 0x8

    public Em7001FrontCatastropheParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CoreBattleTicketParam
{
    [JsonPropertyName("attackNum_")]
    public int AttackNum { get; set; } // Offset 0x8

    public Em7001CoreBattleTicketParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001DownReactionParam
{
    [JsonPropertyName("downDamageReactionSec_")]
    public float DownDamageReactionSec { get; set; } // Offset 0x8

    [JsonPropertyName("downDamageLimitHpRate_")]
    public float DownDamageLimitHpRate { get; set; } // Offset 0xC

    public Em7001DownReactionParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001DarkFloorShotParam
{
    [JsonPropertyName("radius_")]
    public float Radius { get; set; } // Offset 0x8

    [JsonPropertyName("explosionAttackRate_")]
    public float ExplosionAttackRate { get; set; } // Offset 0xC

    [JsonPropertyName("explosionBreakRate_")]
    public float ExplosionBreakRate { get; set; } // Offset 0x10

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } // Offset 0x14

    [JsonPropertyName("slowSec_")]
    public float SlowSec { get; set; } // Offset 0x18

    [JsonPropertyName("isExplosion_")]
    public bool IsExplosion { get; set; } // Offset 0x1C

    public Em7001DarkFloorShotParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001AttributeBuffParam
{
    [JsonPropertyName("fireAttrAttackUpBuff_")]
    public float FireAttrAttackUpBuff { get; set; } // Offset 0x8

    [JsonPropertyName("earthAttrDefUpBuff_")]
    public float EarthAttrDefUpBuff { get; set; } // Offset 0xC

    [JsonPropertyName("windAttrDrainBuff_")]
    public float WindAttrDrainBuff { get; set; } // Offset 0x10

    public Em7001AttributeBuffParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CoreBarrierParam
{
    [JsonPropertyName("fireCoreHp_")]
    public int FireCoreHp { get; set; } // Offset 0x8

    [JsonPropertyName("waterCoreHp_")]
    public int WaterCoreHp { get; set; } // Offset 0xC

    [JsonPropertyName("earthCoreHp_")]
    public int EarthCoreHp { get; set; } // Offset 0x10

    [JsonPropertyName("windCoreHp_")]
    public int WindCoreHp { get; set; } // Offset 0x14

    [JsonPropertyName("damageCut_")]
    public float DamageCut { get; set; } // Offset 0x18

    [JsonPropertyName("changeVfx1stRate_")]
    public float ChangeVfx1stRate { get; set; } // Offset 0x1C

    [JsonPropertyName("changeVfx2stRate_")]
    public float ChangeVfx2stRate { get; set; } // Offset 0x20

    [JsonPropertyName("changeVfx3stRate_")]
    public float ChangeVfx3stRate { get; set; } // Offset 0x24

    public Em7001CoreBarrierParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MovePassListParam
{
    [JsonPropertyName("movePassList_")]
    public BindingList<Em7001MovePassParam> MovePassList { get; set; } = []; // std::vector<Em7001MovePassParam> - Offset 0x8

    public Em7001MovePassListParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001FlightParam
{
    [JsonPropertyName("speed_")]
    public float Speed { get; set; } // Offset 0x8

    [JsonPropertyName("moveExecDamage_")]
    public int MoveExecDamage { get; set; } // Offset 0xC

    [JsonPropertyName("flyDurationSecMin_")]
    public float FlyDurationSecMin { get; set; } // Offset 0x10

    [JsonPropertyName("flyDurationSecMax_")]
    public float FlyDurationSecMax { get; set; } // Offset 0x14

    [JsonPropertyName("flyMotionIntervalSec_")]
    public float FlyMotionIntervalSec { get; set; } // Offset 0x18

    public Em7001FlightParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MoveBlendAnimParam
{
    [JsonPropertyName("addBlendRotAngleY_")]
    public float AddBlendRotAngleY { get; set; } // Offset 0x8

    [JsonPropertyName("rollSpeed_")]
    public float RollSpeed { get; set; } // Offset 0xC

    public Em7001MoveBlendAnimParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CatastropheParam
{
    [JsonPropertyName("shotParam_")]
    public Em7001WideAreaShotParam ShotParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shotOffsetSec_")]
    public float ShotOffsetSec { get; set; } // Offset 0x10

    public Em7001CatastropheParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MotionFlyParam
{
    [JsonPropertyName("animMoveRate_")]
    public float AnimMoveRate { get; set; } // Offset 0x10

    [JsonPropertyName("basePosParam_")]
    public Em7001PositionParam BasePosParam { get; set; } // Offset 0xCF543FFA

    public Em7001MotionFlyParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CoreOffsetPosParam
{
    [JsonPropertyName("offsetParams_")]
    [Editable(false)]
    public BindingList<float> OffsetParams { get; set; } = [..Enumerable.Repeat(0, 3)]; // std::array<float,3> Offset 0x8

    public Em7001CoreOffsetPosParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001RideDeckParam
{
    [JsonPropertyName("idleSec_")]
    public float IdleSec { get; set; } // Offset 0x10

    [JsonPropertyName("nearAddOffsetLength_")]
    public float NearAddOffsetLength { get; set; } // Offset 0x14

    [JsonPropertyName("rightSidePosParam_")]
    public Em7001PositionParam RightSidePosParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("leftSidePosParam_")]
    public Em7001PositionParam LeftSidePosParam { get; set; } // Offset 0xCF543FFA

    public Em7001RideDeckParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001SuperReginRaveParam
{
    [JsonPropertyName("createExplosionIntervalSec_")]
    public float CreateExplosionIntervalSec { get; set; } // Offset 0x8

    [JsonPropertyName("waitExplosionSec_")]
    public float WaitExplosionSec { get; set; } // Offset 0xC

    public Em7001SuperReginRaveParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MagicCircleListParam
{
    [JsonPropertyName("list_")]
    public BindingList<Em7001MagicCircleParam> List { get; set; } = []; // std::vector<Em7001MagicCircleParam> - Offset 0x10

    [JsonPropertyName("magicCircleAttackSec_")]
    public float MagicCircleAttackSec { get; set; } // Offset 0x8

    public Em7001MagicCircleListParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001SuperNovaParam
{
    [JsonPropertyName("shotParam_")]
    public Em7001WideAreaShotParam ShotParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shotOffsetSec_")]
    public float ShotOffsetSec { get; set; } // Offset 0x10

    [JsonPropertyName("magicCircleListParam_")]
    public Em7001MagicCircleListParam MagicCircleListParam { get; set; } // Offset 0xCF543FFA

    public Em7001SuperNovaParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ActionCommandParam
{
    [JsonPropertyName("commandInfoList_")]
    [Editable(false)]
    // std::array<std::vector<std::vector<Em7001ActionCommandParam::Chunk>,4> Offset 0x10
    public BindingList<BindingList<BindingList<Chunk>>> CommandInfoList { get; set; } = [..Enumerable.Repeat(new BindingList<BindingList<Chunk>>(), 4)]; 

    [JsonPropertyName("reginRaveIntervalSec_")]
    public float ReginRaveIntervalSec { get; set; } // Offset 0x8

    public Em7001ActionCommandParam()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class Chunk
    {
        [JsonPropertyName("commands_")]
        public BindingList<CommandInfo> Commands { get; set; } = []; // Offset 0x8

        [JsonPropertyName("countTransParams_")]
        public BindingList<CountTransition> CountTransParams { get; set; } = []; // Offset 0x20

        public Chunk()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CommandInfo
    {
        [JsonPropertyName("action_")]
        public int Action { get; set; } // Offset 0x8

        [JsonPropertyName("condition_")]
        public int Condition { get; set; } // Offset 0xC

        [JsonPropertyName("isSuccessReverse_")]
        public bool IsSuccessReverse { get; set; } // Offset 0x10

        [JsonPropertyName("intervalSec_")]
        public float IntervalSec { get; set; } // Offset 0x14

        [JsonPropertyName("probability_")]
        public int Probability { get; set; } // Offset 0x18

        [JsonPropertyName("isHLCommnad_")]
        public bool IsHLCommnad { get; set; } // Offset 0x1C

        public CommandInfo()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class CountTransition
    {
        [JsonPropertyName("changeCount_")]
        public int ChangeCount { get; set; } // Offset 0x8

        [JsonPropertyName("nextPattern_")]
        public int NextPattern { get; set; } // Offset 0xC

        [JsonPropertyName("nextState_")]
        public int NextState { get; set; } // Offset 0x10

        public CountTransition()
        {
        }
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001AnimRateParam
{
    [JsonPropertyName("phase2ODAnimRate_")]
    public float Phase2ODAnimRate { get; set; } // Offset 0x8

    [JsonPropertyName("phase3ODAnimRate_")]
    public float Phase3ODAnimRate { get; set; } // Offset 0xC

    public Em7001AnimRateParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001CameraParam
{
    [JsonPropertyName("nearCameraDistance_")]
    public float NearCameraDistance { get; set; } // Offset 0x8

    [JsonPropertyName("nearCameraReturnSec_")]
    public float NearCameraReturnSec { get; set; } // Offset 0xC

    [JsonPropertyName("nearCameraLookUpBaseY_")]
    public float NearCameraLookUpBaseY { get; set; } // Offset 0x10

    [JsonPropertyName("normalCameraLookUpBaseY_")]
    public float NormalCameraLookUpBaseY { get; set; } // Offset 0x14

    [JsonPropertyName("cameraCtrlInfoPosRightOnly_")]
    public BindingList<CameraCtrlInfo> CameraCtrlInfoPosRightOnly { get; set; } = []; // Offset 0x30

    [JsonPropertyName("cameraCtrlInfoPosFree_")]
    public BindingList<CameraCtrlInfo> CameraCtrlInfoPosFree { get; set; } = []; // Offset 0x48

    [JsonPropertyName("fixedCameraRotRate_")]
    public float FixedCameraRotRate { get; set; } // Offset 0x28

    [JsonPropertyName("fixedCameraRotMax_")]
    public float FixedCameraRotMax { get; set; } // Offset 0x2C

    [JsonPropertyName("cameraMoveEaseParam_")]
    public EaseParam CameraMoveEaseParam { get; set; } // Offset 0xCF543FFA

    public Em7001CameraParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class CameraCtrlInfo
{
    [JsonPropertyName("dataType_")]
    public int DataType { get; set; } // Offset 0x10

    [JsonPropertyName("triggerFrame_")]
    public int TriggerFrame { get; set; } // Offset 0x14

    [JsonPropertyName("durationFrame_")]
    public int DurationFrame { get; set; } // Offset 0x18

    [JsonPropertyName("offsetPosFromPL_")]
    public Vector4 OffsetPosFromPL { get; set; } // Offset 0x20

    [JsonPropertyName("isEnableFlag_")]
    public bool IsEnableFlag { get; set; } // Offset 0x30

    public CameraCtrlInfo()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001EtherCannonParam
{
    [JsonPropertyName("catastropheRepairSec_")]
    public float CatastropheRepairSec { get; set; } // Offset 0x8

    [JsonPropertyName("supernovaRepairSec_")]
    public float SupernovaRepairSec { get; set; } // Offset 0xC

    public Em7001EtherCannonParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001PartsBreakParam
{
    [JsonPropertyName("headHp_")]
    public int HeadHp { get; set; } // Offset 0x8

    [JsonPropertyName("shoulderHp_")]
    public int ShoulderHp { get; set; } // Offset 0xC

    public Em7001PartsBreakParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ForcedDefeatParam
{
    [JsonPropertyName("lightBulletParams_")]
    public Em7001LightBulletActionParam LightBulletParams { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shotParam_")]
    public Em7001WideAreaShotParam ShotParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("summonCoreParam_")]
    public Em7001DarkCoreSummonParam SummonCoreParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("startForcedDefeatSec_")]
    public float StartForcedDefeatSec { get; set; } // Offset 0x10

    [JsonPropertyName("startForcedDefeatAttributeAttackCount_")]
    public int StartForcedDefeatAttributeAttackCount { get; set; } // Offset 0x14

    [JsonPropertyName("forcedDefeatModeSec_")]
    public float ForcedDefeatModeSec { get; set; } // Offset 0x18

    [JsonPropertyName("fadeOutSec_")]
    public float FadeOutSec { get; set; } // Offset 0x1C

    [JsonPropertyName("catastorpheChargeSec_")]
    public float CatastorpheChargeSec { get; set; } // Offset 0x20

    public Em7001ForcedDefeatParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001PositionListParam
{
    [JsonPropertyName("positionList_")]
    public BindingList<Em7001PositionParam> PositionList { get; set; } = []; // Offset 0x8

    public Em7001PositionListParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MovePassParam
{
    [JsonPropertyName("posListParam_")]
    public Em7001PositionListParam PosListParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; } // Offset 0x28

    public Em7001MovePassParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001TackleParam
{
    [JsonPropertyName("tackleMovePassParam_")]
    public Em7001MovePassParam TackleMovePassParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("backMovePassParam_")]
    public Em7001MovePassParam BackMovePassParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("tackleAttackAreaParam_")]
    public Em7001WideAreaShotParam TackleAttackAreaParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("groundAttackAreaParam_")]
    public Em7001WideAreaShotParam GroundAttackAreaParam { get; set; } // Offset 0xCF543FFA

    public Em7001TackleParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001RideDeckReginRaveParam
{
    [JsonPropertyName("list_")]
    public BindingList<BindingList<int>> List { get; set; } = []; // Offset 0x8

    public Em7001RideDeckReginRaveParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ClawBeamParam
{
    [JsonPropertyName("rightShockWaveParams_")]
    public BindingList<Em7001ExplodeShockWaveParam> RightShockWaveParams { get; set; } = []; // Offset 0x8

    [JsonPropertyName("leftShockWaveParams_")]
    public BindingList<Em7001ExplodeShockWaveParam> LeftShockWaveParams { get; set; } = []; // Offset 0x20

    [JsonPropertyName("attackCount_")]
    public int AttackCount { get; set; } // Offset 0x38

    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x3C

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0x40

    public Em7001ClawBeamParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ShockWaveParam
{
    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x8

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0xC

    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } // Offset 0x10

    [JsonPropertyName("endRadius_")]
    public float EndRadius { get; set; } // Offset 0x14

    [JsonPropertyName("scaleSec_")]
    public float ScaleSec { get; set; } // Offset 0x18

    public Em7001ShockWaveParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001LaserParam
{
    [JsonPropertyName("laserAttackRate_")]
    public float LaserAttackRate { get; set; } // Offset 0x38

    [JsonPropertyName("laserBreakRate_")]
    public float LaserBreakRate { get; set; } // Offset 0x3C

    [JsonPropertyName("laserRideAttackRate_")]
    public float LaserRideAttackRate { get; set; } // Offset 0x40

    [JsonPropertyName("laserRideBreakRate_")]
    public float LaserRideBreakRate { get; set; } // Offset 0x44

    [JsonPropertyName("laserSuperAttackRate_")]
    public float LaserSuperAttackRate { get; set; } // Offset 0x48

    [JsonPropertyName("laserSuperBreakRate_")]
    public float LaserSuperBreakRate { get; set; } // Offset 0x4C

    [JsonPropertyName("laserAttackRadius_")]
    public float LaserAttackRadius { get; set; } // Offset 0x50

    [JsonPropertyName("laserGroundedAttackRadius_")]
    public float LaserGroundedAttackRadius { get; set; } // Offset 0x54

    [JsonPropertyName("laserRideDeckAttackRadius_")]
    public float LaserRideDeckAttackRadius { get; set; } // Offset 0x58

    [JsonPropertyName("laserRideDeckGroundedAttackRadius_")]
    public float LaserRideDeckGroundedAttackRadius { get; set; } // Offset 0x5C

    [JsonPropertyName("blowAttackSize_")]
    public Vector4 BlowAttackSize { get; set; } // Offset 0x20

    [JsonPropertyName("blowSec_")]
    public float BlowSec { get; set; } // Offset 0x30

    [JsonPropertyName("blowRate_")]
    public float BlowRate { get; set; } // Offset 0x34

    public Em7001LaserParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MagicCircleCommonParam
{
    [JsonPropertyName("attackParams_")]
    public BindingList<AttackParam> AttackParams { get; set; } = []; // Offset 0x8

    [JsonPropertyName("chaseStopTime_")]
    public float ChaseStopTime { get; set; } // Offset 0x20

    [JsonPropertyName("chaseSpeed_")]
    public float ChaseSpeed { get; set; } // Offset 0x24

    public Em7001MagicCircleCommonParam()
    {
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AttackParam
    {
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; } // Offset 0x8

        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; } // Offset 0xC

        public AttackParam()
        {
        }
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ClawShockWaveParam
{
    [JsonPropertyName("attackRate_")]
    public float AttackRate { get; set; } // Offset 0x8

    [JsonPropertyName("breakRate_")]
    public float BreakRate { get; set; } // Offset 0xC

    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; } // Offset 0x10

    [JsonPropertyName("shotDelaySec_")]
    public float ShotDelaySec { get; set; } // Offset 0x14

    [JsonPropertyName("shotAngle_")]
    [Editable(false)]
    public BindingList<float> ShotAngle { get; set; } = [.. Enumerable.Repeat(0, 2)]; // std::array<float,2> - Offset 0x1C

    [JsonPropertyName("shotPosListParam_")]
    [Editable(false)]
    public BindingList<Em7001PositionListParam> ShotPosListParam { get; set; } = [.. Enumerable.Repeat(new Em7001PositionListParam(), 2)]; // Offset 0x28

    [JsonPropertyName("isGroundedExplosion_")]
    public bool IsGroundedExplosion { get; set; } // Offset 0x18

    public Em7001ClawShockWaveParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001AttackAreaParam
{
    [JsonPropertyName("positionParam_")]
    public Em7001PositionParam PositionParam { get; set; } // Offset 0xCF543FFA

    [JsonPropertyName("shape_")]
    public int Shape { get; set; } // Offset 0x30

    [JsonPropertyName("size_")]
    public Vector4 Size { get; set; } // Offset 0x10

    [JsonPropertyName("degree_")]
    public Vector4 Degree { get; set; } // Offset 0x20

    public Em7001AttackAreaParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001AnimAdjustPosParam
{
    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } // Offset 0xCF543FFA

    public Em7001AnimAdjustPosParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001DownReactionMotParam
{
    [JsonPropertyName("rightFrontId_")]
    public string RightFrontId { get; set; } // Offset 0x8

    [JsonPropertyName("rightBackId_")]
    public string RightBackId { get; set; } // Offset 0x28

    [JsonPropertyName("rightRideId_")]
    public string RightRideId { get; set; } // Offset 0x48

    [JsonPropertyName("leftFrontId_")]
    public string LeftFrontId { get; set; } // Offset 0x68

    [JsonPropertyName("leftBackId_")]
    public string LeftBackId { get; set; } // Offset 0x88

    [JsonPropertyName("leftRideId_")]
    public string LeftRideId { get; set; } // Offset 0xA8

    public Em7001DownReactionMotParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001MagicCircleParam
{
    [JsonPropertyName("radius_")]
    public float Radius { get; set; } // Offset 0x10

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; } // Offset 0x14

    [JsonPropertyName("appearDelaySec_")]
    public float AppearDelaySec { get; set; } // Offset 0x18

    [JsonPropertyName("targetPlayer_")]
    public int TargetPlayer { get; set; } // Offset 0x20

    [JsonPropertyName("attackParamType_")]
    public int AttackParamType { get; set; } // Offset 0x1C

    [JsonPropertyName("attackVfxType_")]
    public int AttackVfxType { get; set; } // Offset 0x24

    [JsonPropertyName("posParam_")]
    public Em7001PositionParam PosParam { get; set; } // Offset 0xCF543FFA

    public Em7001MagicCircleParam()
    {
    }
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001ExplodeShockWaveParam
{
    [JsonPropertyName("offsetShotDist_")]
    public float OffsetShotDist { get; set; } // Offset 0x10

    [JsonPropertyName("offsetShotRotY_")]
    public float OffsetShotRotY { get; set; } // Offset 0x14

    [JsonPropertyName("shotCount_")]
    public int ShotCount { get; set; } // Offset 0x18

    [JsonPropertyName("shotAngleY_")]
    public float ShotAngleY { get; set; } // Offset 0x1C

    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; } // Offset 0x20

    [JsonPropertyName("shotDelaySec_")]
    public float ShotDelaySec { get; set; } // Offset 0x24

    [JsonPropertyName("shotPos_")]
    public Em7001PositionParam ShotPos { get; set; } // Offset 0xCF543FFA

    public Em7001ExplodeShockWaveParam()
    {
    }
}