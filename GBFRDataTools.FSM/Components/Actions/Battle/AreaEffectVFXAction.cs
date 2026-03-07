using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;
using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectVFXAction);

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } = 0;

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = -1;

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; } = 1.0f;

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; } = false;

    [JsonPropertyName("isAreaIn_")]
    public bool IsAreaIn { get; set; } = false;

    [JsonPropertyName("isEffectWorldPos_")]
    public bool IsEffectWorldPos { get; set; } = false;

    [JsonPropertyName("effectOffset_")]
    public /* cVec4 */ Vector4 EffectOffset { get; set; } = Vector4.UnitW;

    public override string GetCaption()
    {
        return EffectId.ToString();
    }
}
