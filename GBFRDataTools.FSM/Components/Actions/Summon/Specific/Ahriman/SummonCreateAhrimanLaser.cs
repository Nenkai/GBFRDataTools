using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Ahriman;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonCreateAhrimanLaser : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCreateAhrimanLaser);

    [JsonPropertyName("isSetShotRot_")]
    public bool IsSetShotRot { get; set; } = false;

    [JsonPropertyName("laserParam_")]
    public LaserParam_ LaserParam { get; set; } = new();

    [JsonPropertyName("targetPosBBName_")]
    public string TargetPosBBName { get; set; }

    [JsonPropertyName("isTriggerOnHitCount_")]
    public bool IsTriggerOnHitCount { get; set; } = false;

    [JsonPropertyName("triggerHitCount_")]
    public int TriggerHitCount { get; set; } = 1;

    [JsonPropertyName("isThroughCollision_")]
    public bool IsThroughCollision { get; set; } = false;

    [JsonPropertyName("normalCheckAngle_")]
    public float NormalCheckAngle { get; set; } = 60f;

    [JsonPropertyName("collisionRadius_")]
    public float CollisionRadius { get; set; } = 0.1f;

    [JsonPropertyName("collisionOffsetY_")]
    public float CollisionOffsetY { get; set; } = 0f;

    public class LaserParam_ /* SoAhrimanBaseLaser::LaserParam */
    {
        [JsonPropertyName("partsNo_")]
        public int PartsNo { get; set; }
    
        [JsonPropertyName("partsCompNo_")]
        public int PartsCompNo { get; set; }
    
        [JsonPropertyName("bbCompKey_")]
        public string BbCompKey { get; set; }
    
        [JsonPropertyName("type_")]
        public int Type { get; set; }
    
        [JsonPropertyName("size_")]
        public float Size { get; set; }
    
        [JsonPropertyName("length_")]
        public float Length { get; set; }
    
        [JsonPropertyName("aliveSec_")]
        public float AliveSec { get; set; }
    
        [JsonPropertyName("speed_")]
        public float Speed { get; set; }
    
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; }
    
        [JsonPropertyName("attackRate_")]
        public float AttackRate { get; set; }
    
        [JsonPropertyName("breakRate_")]
        public float BreakRate { get; set; }
    
        [JsonPropertyName("reaction_")]
        public int Reaction { get; set; }
    
        [JsonPropertyName("hitFlag_")]
        public int HitFlag { get; set; }
    
        [JsonPropertyName("element_")]
        public int Element { get; set; }
    
        [JsonPropertyName("multiHitIntervalSecond_")]
        public float MultiHitIntervalSecond { get; set; }
    
        [JsonPropertyName("multiHitLimit_")]
        public int MultiHitLimit { get; set; }
    
        [JsonPropertyName("isMultiHit_")]
        public bool IsMultiHit { get; set; }
    
        [JsonPropertyName("isAlreadyHitClearEachEntity_")]
        public bool IsAlreadyHitClearEachEntity { get; set; }
    
        [JsonPropertyName("isDamageBreakObject_")]
        public bool IsDamageBreakObject { get; set; }
    
        [JsonPropertyName("debuffAilmentCategory_")]
        public int DebuffAilmentCategory { get; set; }
    
        [JsonPropertyName("debuffAlignmentType_")]
        public int DebuffAlignmentType { get; set; }
    
        [JsonPropertyName("debuffType_")]
        public int DebuffType { get; set; }
    
        [JsonPropertyName("debuffTime_")]
        public float DebuffTime { get; set; }
    
        [JsonPropertyName("debuffRate_")]
        public float DebuffRate { get; set; }
    
        [JsonPropertyName("defaultMoveDegX_")]
        public float DefaultMoveDegX { get; set; }
    
        [JsonPropertyName("isAdjustEyeRotX_")]
        public bool IsAdjustEyeRotX { get; set; }
    
        [JsonPropertyName("isAdjustEyeRotY_")]
        public bool IsAdjustEyeRotY { get; set; }
    
        [JsonPropertyName("isPartsComp_")]
        public bool IsPartsComp { get; set; }
    
        [JsonPropertyName("isBBPosComp_")]
        public bool IsBBPosComp { get; set; }
    
        [JsonPropertyName("isUpdateLengthFromBBPos_")]
        public bool IsUpdateLengthFromBBPos { get; set; }
    
        [JsonPropertyName("homingMinRot_")]
        public float HomingMinRot { get; set; }
    
        [JsonPropertyName("homingMaxRot_")]
        public float HomingMaxRot { get; set; }
    
        [JsonPropertyName("homingSpdRot_")]
        public float HomingSpdRot { get; set; }
    
        [JsonPropertyName("homingRotSpdRate_")]
        public float HomingRotSpdRate { get; set; }
    
        [JsonPropertyName("effectObjId_")]
        [eObjId]
        public int EffectObjId { get; set; }
    
        [JsonPropertyName("effectScale_")]
        public float EffectScale { get; set; }
    
        [JsonPropertyName("laserEffectId_")]
        public int LaserEffectId { get; set; }
    
        [JsonPropertyName("laserRootEffectId_")]
        public int LaserRootEffectId { get; set; }
    
        [JsonPropertyName("laserTipEffectId_")]
        public int LaserTipEffectId { get; set; }
    
        [JsonPropertyName("hitEffectId_")]
        public int HitEffectId { get; set; }
    
        [JsonPropertyName("laserSeDefineName_")]
        public string LaserSeDefineName { get; set; }
    
        [JsonPropertyName("hitSeDefineName_")]
        public string HitSeDefineName { get; set; }
    
        [JsonPropertyName("callSeWallHit_")]
        public bool CallSeWallHit { get; set; }
    
        [JsonPropertyName("shotSeDefineName_")]
        public string ShotSeDefineName { get; set; }
    
        [JsonPropertyName("isForceSoftCall_")]
        public bool IsForceSoftCall { get; set; }
    }
}
