using GBFRDataTools.FSM.Components.Actions.AI.Lyria;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

public class Np0100InfoEffAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Np0100InfoEffAction);

    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; } = 0;
}
