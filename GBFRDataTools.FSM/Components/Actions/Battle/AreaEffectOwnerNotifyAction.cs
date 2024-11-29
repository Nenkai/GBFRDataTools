using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectOwnerNotifyAction : ActionComponent
{
    [JsonPropertyName("notifyIndex_")]
    public int NotifyIndex { get; set; } = 0;
}
