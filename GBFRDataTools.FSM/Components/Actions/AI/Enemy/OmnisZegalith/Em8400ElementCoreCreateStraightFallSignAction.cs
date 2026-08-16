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
public class Em8400ElementCoreCreateStraightFallSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreCreateStraightFallSignAction);

    [JsonPropertyName("signSize_")]
    public float SignSize { get; set; } = 10f;

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 1f;

    [JsonPropertyName("isChangeEffect_")]
    public bool IsChangeEffect { get; set; } = false;

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("effectUseParentObjId_")]
    public bool EffectUseParentObjId { get; set; } = false;

    [JsonPropertyName("effectBaseId_")]
    public int EffectBaseId { get; set; } = -1;

    [JsonPropertyName("effectFillId_")]
    public int EffectFillId { get; set; } = -1;

    [JsonPropertyName("effectVanishId_")]
    public int EffectVanishId { get; set; } = -1;

    [JsonPropertyName("isAddWaveSign_")]
    public bool IsAddWaveSign { get; set; } = false;

    [JsonPropertyName("signWaveSize_")]
    public float SignWaveSize { get; set; } = 10f;

    [JsonPropertyName("signWaveEffectObjId_")]
    [eObjId]
    public int SignWaveEffectObjId { get; set; } = -1;

    [JsonPropertyName("isChangeSignWaveEffect_")]
    public bool IsChangeSignWaveEffect { get; set; } = false;

    [JsonPropertyName("signWaveSignEffectId_")]
    public int SignWaveSignEffectId { get; set; } = -1;
}
