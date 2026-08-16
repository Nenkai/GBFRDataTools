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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonCallWeaponVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCallWeaponVFXAction);

    [JsonPropertyName("targetObjId_")]
    [eObjId]
    public uint TargetObjId { get; set; } = 0xFFFFFFFF;

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public uint EffectObjId { get; set; } = 0xFFFFFFFF;

    [JsonPropertyName("estId_")]
    public int EstId { get; set; } = 0;

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("offsetRot_")]
    public Vector4 OffsetRot { get; set; } = Vector4.UnitW;

    [JsonPropertyName("scale_")]
    public Vector4 Scale { get; set; } = Vector4.One;
}
