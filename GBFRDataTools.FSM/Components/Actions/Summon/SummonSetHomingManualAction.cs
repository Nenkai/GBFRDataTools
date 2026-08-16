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
public class SummonSetHomingManualAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetHomingManualAction);

    [JsonPropertyName("lockOnTurnRate_")]
    public float LockOnTurnRate { get; set; } = 1f;

    [JsonPropertyName("isEnableManualTurnRate_")]
    public bool IsEnableManualTurnRate { get; set; } = false;
}
