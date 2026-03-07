using GBFRDataTools.Entities.Converters;
using GBFRDataTools.Entities.Parameters.Base;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Text.Json.Serialization;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7400;

public class Em7400Param : EmBossBaseParam
{
    [JsonPropertyName("onFootCameraCylinderOffsetYTop_")]
    public float OnFootCameraCylinderOffsetYTop { get; set; } = 3f; // Offset 0x7C0

    [JsonPropertyName("onFootCameraCylinderOffsetYBottom_")]
    public float OnFootCameraCylinderOffsetYBottom { get; set; } = 18f; // Offset 0x7C4

    [JsonPropertyName("onFootCameraCylinderRadius_")]
    public float OnFootCameraCylinderRadius { get; set; } = 20f; // Offset 0x7C8

    [JsonPropertyName("playerApproachSecLimit_")]
    public float PlayerApproachSecLimit { get; set; } = 40f; // Offset 0x7CC

    [JsonPropertyName("playerApproachMultiIncreaseRate_")]
    public float PlayerApproachMultiIncreaseRate { get; set; } = 0.1f; // Offset 0x7D0

    [JsonPropertyName("cameraLengthMax_")]
    public float CameraLengthMax { get; set; } = 15f; // Offset 0x7D4

    [JsonPropertyName("cameraTargetOffsetMaxX_")]
    public float CameraTargetOffsetMaxX { get; set; } = 5f; // Offset 0x7D8

    [JsonPropertyName("cameraTargetOffsetMaxY_")]
    public float CameraTargetOffsetMaxY { get; set; } = 2.8f; // Offset 0x7DC

    [JsonPropertyName("cameraRate_")]
    public float CameraRate { get; set; } = 0.05f; // Offset 0x7E0

    [JsonPropertyName("cameraRateXY_")]
    public float CameraRateXY { get; set; } = 2f; // Offset 0x7E4

    [JsonPropertyName("cameraRangeMin_")]
    public float CameraRangeMin { get; set; } = 60f; // Offset 0x7E8

    [JsonPropertyName("cameraRangeMax_")]
    public float CameraRangeMax { get; set; } = 150f; // Offset 0x7EC

    [JsonPropertyName("blowWindBlowTime_")]
    public float BlowWindBlowTime { get; set; } = 1f; // Offset 0x7F0

    [JsonPropertyName("waitShootDownMissileSec_")]
    public float WaitShootDownMissileSec { get; set; } = 40f; // Offset 0x7F4

    [JsonPropertyName("footMoveAttackParam_")]
    public FootMoveAttackParam FootMoveAttackParam_ { get; set; } // Offset 0x7F8

    [JsonPropertyName("punchRockBulletScaleMin_")]
    public float PunchRockBulletScaleMin { get; set; } = 0.6f; // Offset 0x820

    [JsonPropertyName("punchRockBulletScaleMax_")]
    public float PunchRockBulletScaleMax { get; set; } = 1.3f; // Offset 0x824

    [JsonPropertyName("beamHitStop_")]
    public int BeamHitStop { get; set; } = 10; // Offset 0x828

    [JsonPropertyName("beamRadius_")]
    public float BeamRadius { get; set; } = 8f; // Offset 0x82C

    [JsonPropertyName("beamRadiusDecreaseRate_")]
    public float BeamRadiusDecreaseRate { get; set; } = 0.75f; // Offset 0x830

    [JsonPropertyName("beamImpactRadius_")]
    public float BeamImpactRadius { get; set; } = 12f; // Offset 0x834

    [JsonPropertyName("beamLength_")]
    public float BeamLength { get; set; } = 400f; // Offset 0x838

    [JsonPropertyName("beamOffset_")]
    public float BeamOffset { get; set; } = 20f; // Offset 0x83C

    [JsonPropertyName("beamDamageMovementRate_")]
    public float BeamDamageMovementRate { get; set; } = 5f; // Offset 0x840

    [JsonPropertyName("beamDamageMovementRateY_")]
    public float BeamDamageMovementRateY { get; set; } = 2.5f; // Offset 0x844

    [JsonPropertyName("isEnableMissileKnee_")]
    public bool IsEnableMissileKnee { get; set; } = true; // Offset 0x848

    [JsonPropertyName("missileImpactPosDistXZMin_")]
    public float MissileImpactPosDistXZMin { get; set; } = 100f; // Offset 0x84C

    [JsonPropertyName("missileImpactPosDistXZMax_")]
    public float MissileImpactPosDistXZMax { get; set; } = 200f; // Offset 0x850

    [JsonPropertyName("missileShotIntervalTime_")]
    public float MissileShotIntervalTime { get; set; } = 0.3f; // Offset 0x854

    [JsonPropertyName("missileShotDownIntervalSec_")]
    public float MissileShotDownIntervalSec { get; set; } = 0.6f; // Offset 0x858

    [JsonPropertyName("missileShotDownWaitSec_")]
    public float MissileShotDownWaitSec { get; set; } = 1f; // Offset 0x85C

    [JsonPropertyName("missileShotDownNum_")]
    public int MissileShotDownNum { get; set; } = 6; // Offset 0x860

    [JsonPropertyName("missileAtkRate_")]
    public float MissileAtkRate { get; set; } = 1f; // Offset 0x864

    [JsonPropertyName("missileNum_")]
    public int MissileNum { get; set; } = 6; // Offset 0x868

    [JsonPropertyName("missileBurstCameraViewOffsetPos_")]
    public Vector4 MissileBurstCameraViewOffsetPos { get; set; } = new Vector4(-110f, -17f, 121f, 1f); // Offset 0x870

    [JsonPropertyName("missileBurstCameraTargetOffsetPos_")]
    public Vector4 MissileBurstCameraTargetOffsetPos { get; set; } = new Vector4(0f, 20f, -30f, 1f); // Offset 0x880

    [JsonPropertyName("baileyHealth_")]
    public int BaileyHealth { get; set; } = 150; // Offset 0x8CC

    [JsonPropertyName("baileyThrowingBreakRate_")]
    public float BaileyThrowingBreakRate { get; set; } = 1f; // Offset 0x8D0

    [JsonPropertyName("baileyDamageShakeParam_")]
    public Em7400ShakeParam BaileyDamageShakeParam { get; set; } // Offset 0x8E0

    [JsonPropertyName("baileyCrackedShakeParam_")]
    public Em7400ShakeParam BaileyCrackedShakeParam { get; set; } // Offset 0x930

    [JsonPropertyName("explosionMinRadius_")]
    public float ExplosionMinRadius { get; set; } = 11.5f; // Offset 0x890

    [JsonPropertyName("explosionMaxRadius_")]
    public float ExplosionMaxRadius { get; set; } = 150f; // Offset 0x894

    [JsonPropertyName("explosionAddRadiusBlast_")]
    public float ExplosionAddRadiusBlast { get; set; } = 15f; // Offset 0x898

    [JsonPropertyName("explosionHitStop_")]
    public int ExplosionHitStop { get; set; } = 0; // Offset 0x89C

    [JsonPropertyName("explosionCameraTimer_")]
    public float ExplosionCameraTimer { get; set; } = 3f; // Offset 0x8A0

    [JsonPropertyName("explosionCameraAddLength_")]
    public float ExplosionCameraAddLength { get; set; } = 20f; // Offset 0x8A4

    [JsonPropertyName("explosionCameraRate_")]
    public float ExplosionCameraRate { get; set; } = 0.06f; // Offset 0x8A8

    [JsonPropertyName("explosionDamageMovementRateMin_")]
    public float ExplosionDamageMovementRateMin { get; set; } = 6.25f; // Offset 0x8AC

    [JsonPropertyName("explosionDamageMovementRateMax_")]
    public float ExplosionDamageMovementRateMax { get; set; } = 3.25f; // Offset 0x8B0

    [JsonPropertyName("explosionWindBindSec_")]
    public float ExplosionWindBindSec { get; set; } = 2f; // Offset 0x8B4

    [JsonPropertyName("explosionWindBindLength_")]
    public float ExplosionWindBindLength { get; set; } = 0f; // Offset 0x8B8

    [JsonPropertyName("footOuterIntervalSec_")]
    public float FootOuterIntervalSec { get; set; } = 0.5f; // Offset 0x8BC

    [JsonPropertyName("footOuterSignSec_")]
    public float FootOuterSignSec { get; set; } = 3f; // Offset 0x8C0

    [JsonPropertyName("footOuterRangeMin_")]
    public float FootOuterRangeMin { get; set; } = 30f; // Offset 0x8C4

    [JsonPropertyName("footOuterRangeMax_")]
    public float FootOuterRangeMax { get; set; } = 90f; // Offset 0x8C8

    [JsonPropertyName("punchRockBulletAttackRate_")]
    public float PunchRockBulletAttackRate { get; set; } = 0.8f; // Offset 0x980

    [JsonPropertyName("punchBeamWaveAttackRate_")]
    public float PunchBeamWaveAttackRate { get; set; } = 0.4f; // Offset 0x984

    [JsonPropertyName("beamAttackRate_")]
    public float BeamAttackRate { get; set; } = 2.5f; // Offset 0x988

    [JsonPropertyName("explosionAttackRate_")]
    public float ExplosionAttackRate { get; set; } = 5f; // Offset 0x98C

    [JsonPropertyName("punchRockBulletBreakRate_")]
    public float PunchRockBulletBreakRate { get; set; } = 0.8f; // Offset 0x990

    [JsonPropertyName("punchBeamWaveBreakRate_")]
    public float PunchBeamWaveBreakRate { get; set; } = 0.4f; // Offset 0x994

    [JsonPropertyName("beamBreakRate_")]
    public float BeamBreakRate { get; set; } = 5f; // Offset 0x998

    [JsonPropertyName("explosionBreakRate_")]
    public float ExplosionBreakRate { get; set; } = 6f; // Offset 0x99C

    [JsonPropertyName("aiLevelParams_")]
    public BindingList<AiLevelParam> AiLevelParams { get; set; } = [.. Enumerable.Repeat(new AiLevelParam(), 5)]; // Offset 0x9A0

    [JsonPropertyName("ultimateGunSeatDamageRate_")]
    public float UltimateGunSeatDamageRate { get; set; } = 38f; // Offset 0xCE8

    public Em7400Param()
    {
        Hp = 10000;
        Atk = 2000;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
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
        Battle2SearchLength = 150f;
        Search2battleLength = 150f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 1387;
        UiOffsetY = 0f;
        BasicHitStopTimeRate = 0f;
        DamageReactionHitStopTimeRate = 0f;
        SuperArmorHitStopTimeRate = 0f;
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

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class FootMoveAttackParam // Em7400Param::FootMoveAttackParam
    {
        [JsonPropertyName("posParams_")]
        public BindingList<PosParam> PosParams { get; set; } = []; // Offset 0x8

        [JsonPropertyName("damageMovementRate_")]
        public float DamageMovementRate { get; set; } // Offset 0x20

        [JsonPropertyName("damageMovementRateY_")]
        public float DamageMovementRateY { get; set; } // Offset 0x24

        public class PosParam // Em7400Param::FootMoveAttackParam::PosParam
        {
            [JsonPropertyName("offset_")]
            public Vector4 Offset { get; set; }

            [JsonPropertyName("angle_")]
            public Vector4 Angle { get; set; }

            [JsonPropertyName("size_")]
            public Vector4 Size { get; set; }

            [JsonPropertyName("shape_")]
            public int Shape { get; set; }

            [JsonPropertyName("isHeat_")]
            public bool IsHeat { get; set; }
        }
    }

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class AiLevelParam
    {
        [JsonPropertyName("punchRockBlendPerSec_")]
        public float PunchRockBlendPerSec { get; set; } // Offset 0x8

        [JsonPropertyName("punchRockBulletNum_")]
        public int PunchRockBulletNum { get; set; } // Offset 0xC

        [JsonPropertyName("punchBeamWaveSec_")]
        public float PunchBeamWaveSec { get; set; } // Offset 0x10

        [JsonPropertyName("punchBeamShotNum_")]
        public int PunchBeamShotNum { get; set; } // Offset 0x14

        [JsonPropertyName("punchBeamShotNearDist_")]
        public float PunchBeamShotNearDist { get; set; } // Offset 0x18

        [JsonPropertyName("punchBeamShotFarDist_")]
        public float PunchBeamShotFarDist { get; set; } // Offset 0x1C

        [JsonPropertyName("punchBeamShotOmitRadius_")]
        public float PunchBeamShotOmitRadius { get; set; } // Offset 0x20

        [JsonPropertyName("missileFallNum_")]
        public int MissileFallNum { get; set; } // Offset 0x24

        [JsonPropertyName("missileFallSetIntervalSec_")]
        public float MissileFallSetIntervalSec { get; set; } // Offset 0x28

        [JsonPropertyName("missileFallIntervalSec_")]
        public float MissileFallIntervalSec { get; set; } // Offset 0x2C

        [JsonPropertyName("missileSpeed_")]
        public float MissileSpeed { get; set; } // Offset 0x30

        [JsonPropertyName("explosionRadiusIncreaseRate_")]
        public float ExplosionRadiusIncreaseRate { get; set; } // Offset 0x34

        [JsonPropertyName("explosionLoopTime_")]
        public float ExplosionLoopTime { get; set; } // Offset 0x38

        [JsonPropertyName("explosionAttackDuration_")]
        public float ExplosionAttackDuration { get; set; } // Offset 0x3C

        [JsonPropertyName("footOuterCoolSec_")]
        public float FootOuterCoolSec { get; set; } // Offset 0x40

        [JsonPropertyName("footOuterNum_")]
        public int FootOuterNum { get; set; } // Offset 0x44

        [JsonPropertyName("footCoreMaxHpRate_")]
        public float FootCoreMaxHpRate { get; set; } // Offset 0x48

        [JsonPropertyName("bodyCoreMaxHpRate_")]
        public float BodyCoreMaxHpRate { get; set; } // Offset 0x4C

        [JsonPropertyName("coolTimeParams_")]
        [Editable(false)]
        public BindingList<Vector2> CoolTimeParams { get; set; } = [.. Enumerable.Repeat(new Vector2(), 8)]; // Offset 0x50

        [JsonPropertyName("earthSeedSummonPosList_")]
        public BindingList<Vector4> EarthSeedSummonPosList { get; set; } = []; // Offset 0x90
    }
}