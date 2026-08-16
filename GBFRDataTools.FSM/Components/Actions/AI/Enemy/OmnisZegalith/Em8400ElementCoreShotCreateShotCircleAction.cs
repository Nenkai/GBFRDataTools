using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreShotCreateShotCircleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreShotCreateShotCircleAction);

    [JsonPropertyName("shotSlot_")]
    public int ShotSlot { get; set; } = 0;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0f;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shotCount_")]
    public int ShotCount { get; set; } = 1;

    [JsonPropertyName("createInterval_")]
    public float CreateInterval { get; set; } = 0f;

    [JsonPropertyName("addTime_")]
    public float AddTime { get; set; } = 0f;

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 10f;

    [JsonPropertyName("addRadius_")]
    public float AddRadius { get; set; } = 0f;

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0f;

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; } = 0f;

    [JsonPropertyName("createShotOffsetRot_")]
    public Vector4 CreateShotOffsetRot { get; set; } = Vector4.UnitW;

    [JsonPropertyName("createShotOffsetRadiusRandom_")]
    public float CreateShotOffsetRadiusRandom { get; set; } = 0f;

    [JsonPropertyName("userCustomType_")]
    public int UserCustomType { get; set; } = 0;

    [JsonPropertyName("isTargetPosShot_")]
    public bool IsTargetPosShot { get; set; } = false;

    [JsonPropertyName("targetPosShotStartOffset_")]
    public Vector4 TargetPosShotStartOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUseOwnerPos_")]
    public bool IsUseOwnerPos { get; set; } = true;

    [JsonPropertyName("isUseOwnerRotY_")]
    public bool IsUseOwnerRotY { get; set; } = true;

    [JsonPropertyName("isUseOwnerScale_")]
    public bool IsUseOwnerScale { get; set; } = false;

    [JsonPropertyName("isUseOwnerParts_")]
    public bool IsUseOwnerParts { get; set; } = false;

    [JsonPropertyName("ownerPratsNo_")]
    public int OwnerPratsNo { get; set; } = -1;

    [JsonPropertyName("oneFrameWait_")]
    public bool OneFrameWait { get; set; } = true;

    [JsonPropertyName("isChangeTarget_")]
    public bool IsChangeTarget { get; set; } = false;

    [JsonPropertyName("isCheckStageArea_")]
    public bool IsCheckStageArea { get; set; } = false;

    [JsonPropertyName("checkStageAreaMargin_")]
    public float CheckStageAreaMargin { get; set; } = 0f;

    [JsonPropertyName("isUseShotNotCreateArea_")]
    public bool IsUseShotNotCreateArea { get; set; } = false;
}
