using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class CallObjectVFXAction : ActionComponent
{
    [JsonPropertyName("id_")]
    public int Id { get; set; }

    [JsonPropertyName("isUseCoreEff_")]
    public bool IsUseCoreEff { get; set; }

    [JsonPropertyName("isUseEntityPosition_")]
    public bool IsUseEntityPosition { get; set; }

    [JsonPropertyName("isUseEntityRotation_")]
    public bool IsUseEntityRotation { get; set; }

    [JsonPropertyName("isParentSetting_")]
    public bool IsParentSetting { get; set; }

    [JsonPropertyName("isPartsSetting_")]
    public bool IsPartsSetting { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("offsetPos_")]
    public cVec4 OffsetPos { get; set; }

    [JsonPropertyName("offsetRot_")]
    public cVec4 OffsetRot { get; set; }

    [JsonPropertyName("canEditScaleXYZ_")]
    public bool CanEditScaleXYZ { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; }

    [JsonPropertyName("scaleY_")]
    public float ScaleY { get; set; }

    [JsonPropertyName("scaleZ_")]
    public float ScaleZ { get; set; }

    [JsonPropertyName("partsNo_")]
    public short PartsNo { get; set; }

    [JsonPropertyName("writeControllerNumber_")]
    public bool WriteControllerNumber { get; set; }

    [JsonPropertyName("blackBoardName_")]
    public string BlackBoardName { get; set; }

    [JsonPropertyName("isVanishOnEnd_")]
    public bool IsVanishOnEnd { get; set; }

    [JsonPropertyName("isUseRoomEff_")]
    public bool IsUseRoomEff { get; set; }
}