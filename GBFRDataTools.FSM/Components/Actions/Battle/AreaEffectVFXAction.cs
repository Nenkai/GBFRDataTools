using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectVFXAction : ActionComponent
{
    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; }

    [JsonPropertyName("effectScale_")]
    public float EffectScale { get; set; }

    [JsonPropertyName("isLoop_")]
    public bool IsLoop { get; set; }

    [JsonPropertyName("isAreaIn_")]
    public bool IsAreaIn { get; set; }

    [JsonPropertyName("isEffectWorldPos_")]
    public bool IsEffectWorldPos { get; set; }

    [JsonPropertyName("effectOffset_")]
    public cVec4 EffectOffset { get; set; }
}
