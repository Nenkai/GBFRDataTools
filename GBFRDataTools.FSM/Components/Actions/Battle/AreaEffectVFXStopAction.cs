using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

[GameSupport(GameVersion.EndlessRagnarok)]
public class AreaEffectVFXStopAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectVFXStopAction);

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 0;
}
