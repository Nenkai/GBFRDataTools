using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotVfxAction : ActionComponent
{
    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; }

    [JsonPropertyName("seName_")]
    public string SeName { get; set; }

    [JsonPropertyName("scale_")]
    public float Scale { get; set; }

    [JsonPropertyName("scaleY_")]
    public float ScaleY { get; set; }

    [JsonPropertyName("scaleZ_")]
    public float ScaleZ { get; set; }

    [JsonPropertyName("delCode_")]
    public uint DelCode { get; set; }

    [JsonPropertyName("oneShot_")]
    public bool OneShot { get; set; }

    [JsonPropertyName("isHitEffect_")]
    public bool IsHitEffect { get; set; }

    [JsonPropertyName("isSetHitEffectEspCtrl_")]
    public bool IsSetHitEffectEspCtrl { get; set; }

    [JsonPropertyName("canEditScaleXYZ_")]
    public bool CanEditScaleXYZ { get; set; }

    [JsonPropertyName("isUseParentObjId_")]
    public bool IsUseParentObjId { get; set; }

    [Obsolete("Not used by the game")]
    [JsonPropertyName("isVanishOldEffect_")]
    public bool IsVanishOldEffect { get; set; }

    [JsonPropertyName("isHitEffectKeepFront_")]
    public bool IsHitEffectKeepFront { get; set; }

    [JsonPropertyName("offsetPos_")]
    public cVec4 OffsetPos { get; set; }

    [JsonPropertyName("isUseOffsetPosSE_")]
    public bool IsUseOffsetPosSE { get; set; }

}
