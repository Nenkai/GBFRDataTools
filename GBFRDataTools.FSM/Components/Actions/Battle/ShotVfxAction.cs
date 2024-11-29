using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotVfxAction : ActionComponent
{
    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 0;

    [JsonPropertyName("seName_")]
    public string SeName { get; set; } = string.Empty;

    [JsonPropertyName("scale_")]
    public float Scale { get; set; } = 1.0f;

    [JsonPropertyName("scaleY_")]
    public float ScaleY { get; set; } = 1.0f;

    [JsonPropertyName("scaleZ_")]
    public float ScaleZ { get; set; } = 1.0f;

    [JsonPropertyName("delCode_")]
    public uint DelCode { get; set; } = 0x80000000;

    [JsonPropertyName("oneShot_")]
    public bool OneShot { get; set; } = false;

    [JsonPropertyName("isHitEffect_")]
    public bool IsHitEffect { get; set; } = false;

    [JsonPropertyName("isSetHitEffectEspCtrl_")]
    public bool IsSetHitEffectEspCtrl { get; set; } = false;

    [JsonPropertyName("canEditScaleXYZ_")]
    public bool CanEditScaleXYZ { get; set; } = false;

    [JsonPropertyName("isUseParentObjId_")]
    public bool IsUseParentObjId { get; set; } = false;

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isVanishOldEffect_")]
    public bool IsVanishOldEffect { get; set; }

    [JsonPropertyName("isHitEffectKeepFront_")]
    public bool IsHitEffectKeepFront { get; set; } = false;

    [JsonPropertyName("offsetPos_")]
    public /* cVec4 */ Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUseOffsetPosSE_")]
    public bool IsUseOffsetPosSE { get; set; } = false;

}
