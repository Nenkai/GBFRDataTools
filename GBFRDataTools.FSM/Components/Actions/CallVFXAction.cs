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
    public int Id { get; set; }

    [JsonPropertyName("isUseCoreEff_")]
    public bool IsUseCoreEff { get; set; }

    [JsonPropertyName("isParentSetting_")]
    public bool IsParentSetting { get; set; }

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; }

    [JsonPropertyName("isOwnerSlowRate_")]
    public bool IsOwnerSlowRate { get; set; }
}
