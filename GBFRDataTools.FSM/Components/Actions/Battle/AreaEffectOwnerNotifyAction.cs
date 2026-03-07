using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectOwnerNotifyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectOwnerNotifyAction);

    [JsonPropertyName("notifyIndex_")]
    public int NotifyIndex { get; set; } = 0;
}
