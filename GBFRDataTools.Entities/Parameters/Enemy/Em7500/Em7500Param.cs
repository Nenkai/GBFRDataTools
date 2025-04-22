using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

using static GBFRDataTools.Entities.Parameters.Enemy.Em7700.Em7700Param;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7500;

public class Em7500Param : EmBossBaseParam
{
    [JsonPropertyName("typeParam_")]
    [Editable(false)]
    public BindingList<TypeParam> TypeParam_ { get; set; } = [.. Enumerable.Repeat(new TypeParam(), 3)]; // std::array<Em7500Param::TypeParam,3>

    [JsonPropertyName("createStartBattleWedgeList_")]
    public BindingList<Vector4> CreateStartBattleWedgeList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createAppearanceWedgeList_")]
    public BindingList<Vector4> CreateAppearanceWedgeList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createStartBattleBigWedgeList_")]
    public BindingList<Vector4> CreateStartBattleBigWedgeList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createAppearanceBigWedgeList_")]
    public BindingList<Vector4> CreateAppearanceBigWedgeList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createStartBattleEm2800List_")]
    public BindingList<Vector4> CreateStartBattleEm2800List { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createAppearanceEm2800List_")]
    public BindingList<Vector4> CreateAppearanceEm2800List { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createStartBattleLilithSphereList_")]
    public BindingList<Vector4> CreateStartBattleLilithSphereList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createAppearanceLilithSphereList_")]
    public BindingList<Vector4> CreateAppearanceLilithSphereList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createLilithSphereList_")]
    public BindingList<Vector4> CreateLilithSphereList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("createBigWedgeList_")]
    public BindingList<Vector4> CreateBigWedgeList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("bigWedgeLimit_")]
    public int BigWedgeLimit { get; set; } = 2;

    [JsonPropertyName("darkVortexLimit_")]
    public int DarkVortexLimit { get; set; } = 2;

    [JsonPropertyName("damagePartsNormalTypeLeftHone_")]
    public DamagePartsParam DamagePartsNormalTypeLeftHone { get; set; }

    [JsonPropertyName("damagePartsNormalTypeRightHone_")]
    public DamagePartsParam DamagePartsNormalTypeRightHone { get; set; }

    [JsonPropertyName("damagePartsFinalTypeLeftHone_")]
    public DamagePartsParam DamagePartsFinalTypeLeftHone { get; set; }

    [JsonPropertyName("damagePartsFinalTypeRightHone_")]
    public DamagePartsParam DamagePartsFinalTypeRightHone { get; set; }

    [JsonPropertyName("blueAuraBreakMax_")]
    public int BlueAuraBreakMax { get; set; } = 300;

    [JsonPropertyName("blueAuraOffset_")]
    public Vector4 BlueAuraOffset { get; set; } = new Vector4(0f, 3f, 9f, 1f);

    [JsonPropertyName("blueAuraObjHiSize_")]
    public float BlueAuraObjHiSize { get; set; } = 3f;

    [JsonPropertyName("blueAuraDamageSize_")]
    public float BlueAuraDamageSize { get; set; } = 3f;

    [JsonPropertyName("playerAuraSpeed_")]
    public float PlayerAuraSpeed { get; set; } = 0.01f;

    [JsonPropertyName("darkVortexBallTargetPos_")]
    public float DarkVortexBallTargetPos { get; set; } = 23f;

    [JsonPropertyName("darkVortexLifeSecond_")]
    public float DarkVortexLifeSecond { get; set; } = 15f;

    [JsonPropertyName("darkVortexExpandSecond_")]
    public float DarkVortexExpandSecond { get; set; } = 1f;

    [JsonPropertyName("darkVortexAbsorbRadius_")]
    public float DarkVortexAbsorbRadius { get; set; } = 17f;

    [JsonPropertyName("darkVortexAbsorbPower_")]
    public float DarkVortexAbsorbPower { get; set; } = 3f;

    [JsonPropertyName("darkVortexCenterBallRadius_")]
    public float DarkVortexCenterBallRadius { get; set; } = 2.5f;

    [JsonPropertyName("darkVortexAttackPowerRate_")]
    public float DarkVortexAttackPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("darkVortexBreakPowerRate_")]
    public float DarkVortexBreakPowerRate { get; set; } = 0f;

    [JsonPropertyName("darkVortexBanAbilitySecond_")]
    public float DarkVortexBanAbilitySecond { get; set; } = 20f;

    [JsonPropertyName("darkWaveLifeSecond_")]
    public float DarkWaveLifeSecond { get; set; } = 5f;

    [JsonPropertyName("darkWaveRadius_")]
    public float DarkWaveRadius { get; set; } = 40f;

    [JsonPropertyName("darkWaveExpandSecond_")]
    public float DarkWaveExpandSecond { get; set; } = 5f;

    [JsonPropertyName("darkWaveAttackPowerRate_")]
    public float DarkWaveAttackPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("darkWaveBreakPowerRate_")]
    public float DarkWaveBreakPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("darkWaveBanAbilitySecond_")]
    public float DarkWaveBanAbilitySecond { get; set; } = 20f;

    [JsonPropertyName("darkExplosionPresageSecond_")]
    public float DarkExplosionPresageSecond { get; set; } = 2f;

    [JsonPropertyName("darkExplosionAttackRadisu_")]
    public float DarkExplosionAttackRadisu { get; set; } = 5f;

    [JsonPropertyName("darkExplosionOneLineMax_")]
    public int DarkExplosionOneLineMax { get; set; } = 10;

    [JsonPropertyName("darkExplosionInterval_")]
    public float DarkExplosionInterval { get; set; } = 0.25f;

    [JsonPropertyName("darkExplosionAddIntervalRate_")]
    public float DarkExplosionAddIntervalRate { get; set; } = 0.8f;

    [JsonPropertyName("darkExplosionFluctuation_")]
    public float DarkExplosionFluctuation { get; set; } = 3f;

    [JsonPropertyName("darkExplosionStartOffsetZ_")]
    public float DarkExplosionStartOffsetZ { get; set; } = 20f;

    [JsonPropertyName("darkExplosionAttackPowerRate_")]
    public float DarkExplosionAttackPowerRate { get; set; } = 2f;

    [JsonPropertyName("darkExplosionBreakPowerRate_")]
    public float DarkExplosionBreakPowerRate { get; set; } = 2f;

    [JsonPropertyName("darkExplosionBanAbilitySecond_")]
    public float DarkExplosionBanAbilitySecond { get; set; } = 20f;

    [JsonPropertyName("lilithSphereExplodeHitCount_")]
    public int LilithSphereExplodeHitCount { get; set; } = 1;

    [JsonPropertyName("lilithSpherePresageSecond_")]
    public float LilithSpherePresageSecond { get; set; } = 1f;

    [JsonPropertyName("lilithSphereScale_")]
    public float LilithSphereScale { get; set; } = 2f;

    [JsonPropertyName("lilithExplodeScale_")]
    public float LilithExplodeScale { get; set; } = 1.3f;

    [JsonPropertyName("lilithSphereBodyAttackPowerRate_")]
    public float LilithSphereBodyAttackPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("lilithSphereBodyBreakPowerRate_")]
    public float LilithSphereBodyBreakPowerRate { get; set; } = 0f;

    [JsonPropertyName("lilithSphereExplodeAttackPowerRate_")]
    public float LilithSphereExplodeAttackPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("lilithSphereExplodeBreakPowerRate_")]
    public float LilithSphereExplodeBreakPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("lilithSphereExplodeWaveAttackPowerRate_")]
    public float LilithSphereExplodeWaveAttackPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("lilithSphereExplodeWaveBreakPowerRate_")]
    public float LilithSphereExplodeWaveBreakPowerRate { get; set; } = 0.8f;

    [JsonPropertyName("lilithSphereBanAbilitySecond_")]
    public float LilithSphereBanAbilitySecond { get; set; } = 20f;

    [JsonPropertyName("dimensionDamagePowerRate_")]
    public float DimensionDamagePowerRate { get; set; } = 0.5f;

    [JsonPropertyName("dimensionDamageClearTime_")]
    public float DimensionDamageClearTime { get; set; } = 1f;

    [JsonPropertyName("restraintPlayerHandHealHpRate_")]
    public float RestraintPlayerHandHealHpRate { get; set; } = 0.001f;

    [JsonPropertyName("restraintPlayerAttackPowerRate_")]
    public float RestraintPlayerAttackPowerRate { get; set; } = 0.5f;

    [JsonPropertyName("restraintPlayerAttackClearTime_")]
    public float RestraintPlayerAttackClearTime { get; set; } = 1f;

    [JsonPropertyName("createWedgeMagicCircleHormingSpeed_")]
    public float CreateWedgeMagicCircleHormingSpeed { get; set; } = 0.1f;

    [JsonPropertyName("handLaserAttackPowerRate_")]
    public float HandLaserAttackPowerRate { get; set; } = 1.8f;

    [JsonPropertyName("handLaserBreakPowerRate_")]
    public float HandLaserBreakPowerRate { get; set; } = 1.8f;

    [JsonPropertyName("handStingAttackPowerRate_")]
    public float HandStingAttackPowerRate { get; set; } = 1f;

    [JsonPropertyName("handStingBreakPowerRate_")]
    public float HandStingBreakPowerRate { get; set; } = 2f;

    [JsonPropertyName("homingShotOffsetTime_")]
    public float HomingShotOffsetTime { get; set; } = 0f;

    [JsonPropertyName("moveHomingShotOffsetTime_")]
    public float MoveHomingShotOffsetTime { get; set; } = 0f;

    [JsonPropertyName("moveSkyhomingShotOffsetTime_")]
    public float MoveSkyhomingShotOffsetTime { get; set; } = 8f;

    [JsonPropertyName("vanishCharacterStartWaitTime_")]
    public float VanishCharacterStartWaitTime { get; set; } = 0.25f;

    [JsonPropertyName("vanishCharacterPlayerLoopTime_")]
    public float VanishCharacterPlayerLoopTime { get; set; } = 12f;

    [JsonPropertyName("vanishCharacterLyriaLoopTime_")]
    public float VanishCharacterLyriaLoopTime { get; set; } = 12f;

    [JsonPropertyName("vanishCharacterVyrnLoopTime_")]
    public float VanishCharacterVyrnLoopTime { get; set; } = 8f;

    [JsonPropertyName("odChargeBallAttackPowerRate_")]
    public float OdChargeBallAttackPowerRate { get; set; } = 4f;

    [JsonPropertyName("odChargeBallBreakPowerRate_")]
    public float OdChargeBallBreakPowerRate { get; set; } = 4f;

    [JsonPropertyName("odChargeBallBanSpecialArtsSecond_")]
    public float OdChargeBallBanSpecialArtsSecond { get; set; } = 60f;

    [JsonPropertyName("odChargeHandLaserAttackPowerRate_")]
    public float OdChargeHandLaserAttackPowerRate { get; set; } = 1.1f;

    [JsonPropertyName("odChargeHandLaserBreakPowerRate_")]
    public float OdChargeHandLaserBreakPowerRate { get; set; } = 1.1f;

    [JsonPropertyName("odChargeHandLaserBanSpecialArtsSecond_")]
    public float OdChargeHandLaserBanSpecialArtsSecond { get; set; } = 60f;

    [JsonPropertyName("specialArtsTriggerHpRate1st_")]
    public int SpecialArtsTriggerHpRate1st { get; set; } = 60;

    [JsonPropertyName("specialArtsTriggerHpRate2nd_")]
    public int SpecialArtsTriggerHpRate2nd { get; set; } = 20;

    [JsonPropertyName("specialArtsChargeBallSmallAttackPowerRate_")]
    public float SpecialArtsChargeBallSmallAttackPowerRate { get; set; } = 1.5f;

    [JsonPropertyName("specialArtsChargeBallSmallBreakPowerRate_")]
    public float SpecialArtsChargeBallSmallBreakPowerRate { get; set; } = 1.5f;

    [JsonPropertyName("specialArtsChargeBallFinalAttackPowerRate_")]
    public float SpecialArtsChargeBallFinalAttackPowerRate { get; set; } = 6f;

    [JsonPropertyName("specialArtsChargeBallFinalBreakPowerRate_")]
    public float SpecialArtsChargeBallFinalBreakPowerRate { get; set; } = 6f;

    [JsonPropertyName("specialArtsChargeBallBanSpecialArtsSecond_")]
    public float SpecialArtsChargeBallBanSpecialArtsSecond { get; set; } = 60f;

    [JsonPropertyName("specialArtsHandLaserAttackPowerRate_")]
    public float SpecialArtsHandLaserAttackPowerRate { get; set; } = 1.3f;

    [JsonPropertyName("specialArtsHandLaserBreakPowerRate_")]
    public float SpecialArtsHandLaserBreakPowerRate { get; set; } = 1.3f;

    [JsonPropertyName("specialArtsHandLaserBanSpecialArtsSecond_")]
    public float SpecialArtsHandLaserBanSpecialArtsSecond { get; set; } = 60f;

    [JsonPropertyName("changeEnemyType1TriggerHpRate_")]
    public int ChangeEnemyType1TriggerHpRate { get; set; } = 0;

    [JsonPropertyName("changeEnemyType2TriggerHpRate_")]
    public int ChangeEnemyType2TriggerHpRate { get; set; } = 80;

    [JsonPropertyName("changeEnemyType3TriggerHpRate_")]
    public int ChangeEnemyType3TriggerHpRate { get; set; } = 50;

    [JsonPropertyName("ominousExplosionTriggerHpRate1st_")]
    public int OminousExplosionTriggerHpRate1st { get; set; } = 99;

    [JsonPropertyName("ominousExplosionTriggerHpRate2nd_")]
    public int OminousExplosionTriggerHpRate2nd { get; set; } = 10;

    [JsonPropertyName("ominousExplosionTimeSecond_")]
    public float OminousExplosionTimeSecond { get; set; } = 300f;

    [JsonPropertyName("restraintOffsetPos_")]
    public Vector4 RestraintOffsetPos { get; set; } = new Vector4(0f, 8f, 1.2f, 1f);

    [JsonPropertyName("restraintMoveParam")]
    public float RestraintMoveParam { get; set; } = 0.07f;

    [JsonPropertyName("bystanderOffsetPos_")]
    public Vector4 BystanderOffsetPos { get; set; } = new Vector4(8f, 13f, 12f, 1f);

    [JsonPropertyName("bystanderMoveParam")]
    public float BystanderMoveParam { get; set; } = 0.01f;

    [JsonPropertyName("bodyCharacterMaterialDiscardParamAdd_")]
    public float BodyCharacterMaterialDiscardParamAdd { get; set; } = 0.03f;

    [JsonPropertyName("handCharacterMaterialDiscardParamAdd_")]
    public float HandCharacterMaterialDiscardParamAdd { get; set; } = 0.03f;

    [JsonPropertyName("megaHandCharacterMaterialDiscardParamAdd_")]
    public float MegaHandCharacterMaterialDiscardParamAdd { get; set; } = 0.03f;

    [JsonPropertyName("handCharacterMaterialDiscardParamMiddleCable_")]
    public float HandCharacterMaterialDiscardParamMiddleCable { get; set; } = 0.5f;

    [JsonPropertyName("megaHandCharacterMaterialDiscardParamMiddleCable_")]
    public float MegaHandCharacterMaterialDiscardParamMiddleCable { get; set; } = 0.75f;

    [JsonPropertyName("eyeEmissiveRateMax_")]
    public float EyeEmissiveRateMax { get; set; } = 1f;

    [JsonPropertyName("eyeEmissiveAnimationRate_")]
    public float EyeEmissiveAnimationRate { get; set; } = 0.1f;

    [JsonPropertyName("targetCameraTime_")]
    public float TargetCameraTime { get; set; } = 1f;

    [JsonPropertyName("cameraTime_")]
    [Editable(false)]
    public BindingList<float> CameraTime { get; set; } = [.. Enumerable.Repeat(0, 15)]; // std::array<float,15>

    [JsonPropertyName("lockOnLengthBattle_")]
    public float LockOnLengthBattle { get; set; } = 200f;

    [JsonPropertyName("lockOnAdjustStartRotY_")]
    public float LockOnAdjustStartRotY { get; set; } = 0.7853982f;

    [JsonPropertyName("lockOnAdjustEaseParam_")]
    public EaseParam LockOnAdjustEaseParam { get; set; }

    [JsonPropertyName("enemyType_")]
    public uint EnemyType { get; set; } = 1;

    [JsonPropertyName("stageRadiusSize_")]
    public float StageRadiusSize { get; set; } = 40f;

    [JsonPropertyName("stageCenterPos_")]
    public Vector4 StageCenterPos { get; set; } = new Vector4(-318f, 399f, 737f, 1f);

    public Em7500Param()
    {
        Hp = 100000;
        Atk = 100;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 50;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 100;
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
        CameraLength = 0f;
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

    public class LevelAIParam
    {

        [JsonPropertyName("movePhaseCoolTimeSecond_")]
        public float MovePhaseCoolTimeSecond { get; set; } // Offset 0x8

        [JsonPropertyName("moveTeleportTimeSecond_")]
        public float MoveTeleportTimeSecond { get; set; } // Offset 0xC

        [JsonPropertyName("laserCoolTimeSecond_")]
        public float LaserCoolTimeSecond { get; set; } // Offset 0x10

        [JsonPropertyName("comboCoolTimeSecond_")]
        public float ComboCoolTimeSecond { get; set; } // Offset 0x14

        [JsonPropertyName("darkExplosionCoolTimeSecond_")]
        public float DarkExplosionCoolTimeSecond { get; set; } // Offset 0x18

        [JsonPropertyName("lilithSphereCoolTimeSecond_")]
        public float LilithSphereCoolTimeSecond { get; set; } // Offset 0x1C

        [JsonPropertyName("darkVortexCoolTimeSecond_")]
        public float DarkVortexCoolTimeSecond { get; set; } // Offset 0x20

        [JsonPropertyName("hormingShotCoolTimeSecond_")]
        public float HormingShotCoolTimeSecond { get; set; } // Offset 0x24

        [JsonPropertyName("reviveHandCoolTimeSecond_")]
        public float ReviveHandCoolTimeSecond { get; set; } // Offset 0x28

        [JsonPropertyName("odAbilityCoolTimeSecond_")]
        public float OdAbilityCoolTimeSecond { get; set; } // Offset 0x2C

        [JsonPropertyName("handOrderAcceptanceCoolTimeSecond_")]
        public float HandOrderAcceptanceCoolTimeSecond { get; set; } // Offset 0x58

        [JsonPropertyName("handCreateWedgeCoolTimeSecond_")]
        public float HandCreateWedgeCoolTimeSecond { get; set; } // Offset 0x30

        [JsonPropertyName("handPowerupWedgeCoolTimeSecond_")]
        public float HandPowerupWedgeCoolTimeSecond { get; set; } // Offset 0x34

        [JsonPropertyName("handRepairWedgeCoolTimeSecond_")]
        public float HandRepairWedgeCoolTimeSecond { get; set; } // Offset 0x38

        [JsonPropertyName("handRushAttackCoolTimeSecond_")]
        public float HandRushAttackCoolTimeSecond { get; set; } // Offset 0x3C

        [JsonPropertyName("handTripleLaserAttackCoolTimeSecond_")]
        public float HandTripleLaserAttackCoolTimeSecond { get; set; } // Offset 0x40

        [JsonPropertyName("handSextupleLaserAttackCoolTimeSecond_")]
        public float HandSextupleLaserAttackCoolTimeSecond { get; set; } // Offset 0x44

        [JsonPropertyName("handRestraintAttackCoolTimeSecond_")]
        public float HandRestraintAttackCoolTimeSecond { get; set; } // Offset 0x48

        [JsonPropertyName("megahandOrderAcceptanceCoolTimeSecond_")]
        public float MegahandOrderAcceptanceCoolTimeSecond { get; set; } // Offset 0x5C

        [JsonPropertyName("megaHandRushAttackCoolTimeSecond_")]
        public float MegaHandRushAttackCoolTimeSecond { get; set; } // Offset 0x4C

        [JsonPropertyName("megaHandDarkVortexAttackCoolTimeSecond_")]
        public float MegaHandDarkVortexAttackCoolTimeSecond { get; set; } // Offset 0x50

        [JsonPropertyName("megaHandCreateBigWedgeCoolTimeSecond_")]
        public float MegaHandCreateBigWedgeCoolTimeSecond { get; set; } // Offset 0x54

        [JsonPropertyName("handTargetPlayerAttackMax_")]
        public int HandTargetPlayerAttackMax { get; set; } // Offset 0x60

        [JsonPropertyName("megaHandTargetPlayerAttackMax_")]
        public int MegaHandTargetPlayerAttackMax { get; set; } // Offset 0x64

        [JsonPropertyName("createDimensionObjLimit_")]
        public int CreateDimensionObjLimit { get; set; } // Offset 0x68

        [JsonPropertyName("createLilithSphereLimit")]
        public int CreateLilithSphereLimit { get; set; } // Offset 0x6C

        [JsonPropertyName("oneCreateLilithSphereMax")]
        public int OneCreateLilithSphereMax { get; set; } // Offset 0x70

        [JsonPropertyName("handStingWaitTime_")]
        public float HandStingWaitTime { get; set; } // Offset 0x74

        [JsonPropertyName("handLaserShotTime_")]
        public float HandLaserShotTime { get; set; } // Offset 0x78

        [JsonPropertyName("handLaserSpeedMax_")]
        public float HandLaserSpeedMax { get; set; } // Offset 0x7C

        [JsonPropertyName("handLaserSpeedAdd_")]
        public float HandLaserSpeedAdd { get; set; } // Offset 0x80

        [JsonPropertyName("handDamageToBodyDamageRate_")]
        public float HandDamageToBodyDamageRate { get; set; } // Offset 0x84

        [JsonPropertyName("megaHandDamageToBodyDamageRate_")]
        public float MegaHandDamageToBodyDamageRate { get; set; } // Offset 0x88

        [JsonPropertyName("odHandDmageCutRate_")]
        public float OdHandDmageCutRate { get; set; } // Offset 0x8C

        [JsonPropertyName("spBigWedgeDmageCutRate_")]
        public float SpBigWedgeDmageCutRate { get; set; } // Offset 0x90

        [JsonPropertyName("bodyNormalDownWaitTime_")]
        public float BodyNormalDownWaitTime { get; set; } // Offset 0x94

        [JsonPropertyName("handNormalDownWaitTime_")]
        public float HandNormalDownWaitTime { get; set; } // Offset 0x98

        [JsonPropertyName("megaHandNormalDownWaitTime_")]
        public float MegaHandNormalDownWaitTime { get; set; } // Offset 0x9C

        [JsonPropertyName("bodyLightPillerDownWaitTime_")]
        public float BodyLightPillerDownWaitTime { get; set; } // Offset 0xA0

        [JsonPropertyName("handLightPillerDownWaitTime_")]
        public float HandLightPillerDownWaitTime { get; set; } // Offset 0xA4

        [JsonPropertyName("megaHandLightPillerDownWaitTime_")]
        public float MegaHandLightPillerDownWaitTime { get; set; } // Offset 0xA8

        [JsonPropertyName("odAttackHandLaserShotTime_")]
        public float OdAttackHandLaserShotTime { get; set; } // Offset 0xAC

        [JsonPropertyName("odAttackHandLaserSpeedMax_")]
        public float OdAttackHandLaserSpeedMax { get; set; } // Offset 0xB0

        [JsonPropertyName("odAttackHandLaserSpeedAdd_")]
        public float OdAttackHandLaserSpeedAdd { get; set; } // Offset 0xB4

        [JsonPropertyName("odAttackHandChargeTime_")]
        public float OdAttackHandChargeTime { get; set; } // Offset 0xB8

        [JsonPropertyName("isUseSpecialArts1st_")]
        public bool IsUseSpecialArts1st { get; set; } // Offset 0xBC

        [JsonPropertyName("isUseSpecialArts2st_")]
        public bool IsUseSpecialArts2st { get; set; } // Offset 0xBD

        [JsonPropertyName("isUseMultiQuestSpecialArts1st_")]
        public bool IsUseMultiQuestSpecialArts1st { get; set; } // Offset 0xBE

        [JsonPropertyName("isUseMultiQuestSpecialArts2st_")]
        public bool IsUseMultiQuestSpecialArts2st { get; set; } // Offset 0xBF

        [JsonPropertyName("isOminousExplosion1st_")]
        public bool IsOminousExplosion1st { get; set; } // Offset 0xC0

        [JsonPropertyName("isOminousExplosion2st_")]
        public bool IsOminousExplosion2st { get; set; } // Offset 0xC1

        [JsonPropertyName("isDarkVortexBanAbility_")]
        public bool IsDarkVortexBanAbility { get; set; } // Offset 0xC2

        [JsonPropertyName("isDarkWaveBanAbility_")]
        public bool IsDarkWaveBanAbility { get; set; } // Offset 0xC3

        [JsonPropertyName("isDarkExplosionBanAbility_")]
        public bool IsDarkExplosionBanAbility { get; set; } // Offset 0xC4

        [JsonPropertyName("isLilithSphereBanAbility_")]
        public bool IsLilithSphereBanAbility { get; set; } // Offset 0xC5

        [JsonPropertyName("isBodyLaserBanAbility_")]
        public bool IsBodyLaserBanAbility { get; set; } // Offset 0xC6

        [JsonPropertyName("isOdChargeBallBanSpecialArts_")]
        public bool IsOdChargeBallBanSpecialArts { get; set; } // Offset 0xC7

        [JsonPropertyName("isOdChargeHandLaserBanSpecialArts_")]
        public bool IsOdChargeHandLaserBanSpecialArts { get; set; } // Offset 0xC8

        [JsonPropertyName("isSpecialArtsChargeBallBanSpecialArts_")]
        public bool IsSpecialArtsChargeBallBanSpecialArts { get; set; } // Offset 0xC9

        [JsonPropertyName("isSpecialArtsHandLaserBanSpecialArts_")]
        public bool IsSpecialArtsHandLaserBanSpecialArts { get; set; } // Offset 0xCA

        [JsonPropertyName("useActionParam_")]
        [Editable(false)]
        public BindingList<UseActionParam> UseActionParam { get; set; } = [.. Enumerable.Repeat(new UseActionParam(), 3)]; // Offset 0xCA
    }

    public class UseActionParam
    {
        [JsonPropertyName("useAction_")]
        [Editable(false)]
        public BindingList<bool> UseAction { get; set; } = [.. Enumerable.Repeat(false, 41)];// Offset 0x8

        [JsonPropertyName("stayBodyHpRate_")]
        public int StayBodyHpRate { get; set; } // Offset 0x34

        [JsonPropertyName("customOverDriveParam_")]
        public OverDriveParam CustomOverDriveParam { get; set; } // Offset 0x38
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TypeParam
    {
        [JsonPropertyName("handLimit_")]
        public int HandLimit { get; set; } // Offset 0x8

        [JsonPropertyName("megaHandLimit_")]
        public int MegaHandLimit { get; set; } // Offset 0xC

        [JsonPropertyName("levelAIParam_")]
        [Editable(false)]
        public BindingList<LevelAIParam> LevelAIParam { get; set; } = [..Enumerable.Repeat(new LevelAIParam(), 5)]; // Offset 0x10

        public TypeParam()
        {
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class DamagePartsParam
    {
        [JsonPropertyName("break_")]
        public int Break { get; set; } // Offset 0x8

        public DamagePartsParam()
        {
        }
    }
}