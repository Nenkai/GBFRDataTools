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
public class SummonSetEffectPopupAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetEffectPopupAction);

    [JsonPropertyName("pattern_")]
    public int Pattern { get; set; } = 0;
}
