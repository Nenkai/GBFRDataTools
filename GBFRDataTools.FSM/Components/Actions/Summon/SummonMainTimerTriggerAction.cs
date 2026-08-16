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
public class SummonMainTimerTriggerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonMainTimerTriggerAction);

    [JsonPropertyName("isUpdateTimer_")]
    public bool IsUpdateTimer { get; set; } = true;
}
