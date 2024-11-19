using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0100InfoEffAction : ActionComponent
{
    [JsonPropertyName("effectId_")]
    public int EffectId { get; set; }
}
