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
public class SummonChangeHitVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonChangeHitVFXAction);

    [JsonPropertyName("isChangeHitVFX_")]
    public bool IsChangeHitVFX { get; set; } = false;

    [JsonPropertyName("objId_")]
    [eObjId]
    public uint ObjId { get; set; } = 0x7C0000;

    [JsonPropertyName("estId_")]
    public uint EstId { get; set; } = 0xFFFFFFFF;
}
