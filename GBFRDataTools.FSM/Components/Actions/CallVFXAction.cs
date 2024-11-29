using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions;

public class CallVFXAction : ActionComponent
{
    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;

    [JsonPropertyName("isUseCoreEff_")]
    public bool IsUseCoreEff { get; set; } = false;

    [JsonPropertyName("isParentSetting_")]
    public bool IsParentSetting { get; set; } = false;

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("isOwnerSlowRate_")]
    public bool IsOwnerSlowRate { get; set; } = false;
}
