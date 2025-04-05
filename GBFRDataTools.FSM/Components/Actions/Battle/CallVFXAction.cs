using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class CallVFXAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallVFXAction);

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("isUseCoreEff_")]
    public bool IsUseCoreEff { get; set; } = false;

    [JsonPropertyName("isParentSetting_")]
    public bool IsParentSetting { get; set; } = false;

    [JsonPropertyName("effectObjId_")]
    [eObjId]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("isOwnerSlowRate_")]
    public bool IsOwnerSlowRate { get; set; } = false;
}
