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
public class SummonDisableExFallOnLandingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonDisableExFallOnLandingAction);

    [JsonPropertyName("isEnableEnd_")]
    public bool IsEnableEnd { get; set; } = false;

    [JsonPropertyName("isEndSoon_")]
    public bool IsEndSoon { get; set; } = false;
}
