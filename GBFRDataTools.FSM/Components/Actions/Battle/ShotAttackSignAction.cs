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

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotAttackSignAction);

    [JsonPropertyName("shape_")]
    public ShapeType Shape { get; set; } = ShapeType.Circle;

    [JsonPropertyName("size_")]
    public /* cVec4 */ Vector4 Size { get; set; } = Vector4.UnitW;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;

    [JsonPropertyName("posType_")]
    public int PosType { get; set; } = 0;

    [JsonPropertyName("posOffset_")]
    public /* cVec4 */ Vector4 PosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("lineEndOffset_")]
    public /* cVec4 */ Vector4 LineEndOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUpdateAttach_")]
    public bool IsUpdateAttach { get; set; } = false;

    [JsonPropertyName("isUpdateLineEnd_")]
    public bool IsUpdateLineEnd { get; set; } = true;

    [JsonPropertyName("isApplyScale_")]
    public bool IsApplyScale { get; set; } = false;

    [JsonPropertyName("isAdjustScaleY_")]
    public bool IsAdjustScaleY { get; set; } = false;

    [JsonPropertyName("signScaleY_")]
    public float SignScaleY { get; set; } = 1.0f;

    [JsonPropertyName("isChangeEffect_")]
    public bool IsChangeEffect { get; set; } = false;

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } = 0;

    [JsonPropertyName("effectUseParentObjId_")]
    public bool EffectUseParentObjId { get; set; } = false;

    [JsonPropertyName("effectBaseId_")]
    public int EffectBaseId { get; set; } = -1;

    [JsonPropertyName("effectFillId_")]
    public int EffectFillId { get; set; } = -1;

    [JsonPropertyName("effectVanishId_")]
    public int EffectVanishId { get; set; } = -1;
}
