using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectReserveTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectReserveTargetAction);

    [JsonPropertyName("target_")]
    public int Target { get; set; } = 0;

    [JsonPropertyName("findRange_")]
    public float FindRange { get; set; } = 5.0f;
}
