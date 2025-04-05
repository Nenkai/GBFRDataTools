using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class CallObjectVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallObjectVFXAction);

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("isUseCoreEff_")]
    public bool IsUseCoreEff { get; set; } = false;

    [JsonPropertyName("isUseEntityPosition_")]
    public bool IsUseEntityPosition { get; set; } = false;

    [JsonPropertyName("isUseEntityRotation_")]
    public bool IsUseEntityRotation { get; set; } = false;

    [JsonPropertyName("isParentSetting_")]
    public bool IsParentSetting { get; set; } = false;

    [JsonPropertyName("isPartsSetting_")]
    public bool IsPartsSetting { get; set; } = false;

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("offsetPos_")]
    public /* cVec4 */ Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("offsetRot_")]
    public /* cVec4 */ Vector4 OffsetRot { get; set; } = Vector4.UnitW;

    [JsonPropertyName("canEditScaleXYZ_")]
    public bool CanEditScaleXYZ { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("scaleY_")]
    public float ScaleY { get; set; } = 1.0f;

    [JsonPropertyName("scaleZ_")]
    public float ScaleZ { get; set; } = 1.0f;

    [JsonPropertyName("partsNo_")]
    public short PartsNo { get; set; } = 0;

    [JsonPropertyName("writeControllerNumber_")]
    public bool WriteControllerNumber { get; set; } = false;

    [JsonPropertyName("blackBoardName_")]
    public string BlackBoardName { get; set; } = string.Empty;

    [JsonPropertyName("isVanishOnEnd_")]
    public bool IsVanishOnEnd { get; set; } = false;

    [JsonPropertyName("isUseRoomEff_")]
    public bool IsUseRoomEff { get; set; } = false;
}