using GBFRDataTools.FSM.Entities;

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
    [JsonPropertyName("target_")]
    public int Target { get; set; }

    [JsonPropertyName("findRange_")]
    public float FindRange { get; set; }
}
