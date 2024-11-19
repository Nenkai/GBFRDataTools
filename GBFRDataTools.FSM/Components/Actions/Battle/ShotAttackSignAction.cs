using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotAttackSignAction : ActionComponent
{
    [JsonPropertyName("shape_")]
    public int Shape { get; set; }

    [JsonPropertyName("size_")]
    public cVec4 Size { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("posType_")]
    public int PosType { get; set; }

    [JsonPropertyName("posOffset_")]
    public cVec4 PosOffset { get; set; }

    [JsonPropertyName("lineEndOffset_")]
    public cVec4 LineEndOffset { get; set; }

    [JsonPropertyName("isUpdateAttach_")]
    public bool IsUpdateAttach { get; set; }

    [JsonPropertyName("isUpdateLineEnd_")]
    public bool IsUpdateLineEnd { get; set; }

    [JsonPropertyName("isApplyScale_")]
    public bool IsApplyScale { get; set; }

    [JsonPropertyName("isAdjustScaleY_")]
    public bool IsAdjustScaleY { get; set; }

    [JsonPropertyName("signScaleY_")]
    public float SignScaleY { get; set; }

    [JsonPropertyName("isChangeEffect_")]
    public bool IsChangeEffect { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("effectUseParentObjId_")]
    public bool EffectUseParentObjId { get; set; }

    [JsonPropertyName("effectBaseId_")]
    public int EffectBaseId { get; set; }

    [JsonPropertyName("effectFillId_")]
    public int EffectFillId { get; set; }

    [JsonPropertyName("effectVanishId_")]
    public int EffectVanishId { get; set; }
}
