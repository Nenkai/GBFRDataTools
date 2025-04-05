using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0000JackEm7200Action : ActionComponent
{
    [JsonPropertyName("fsmNo_")]
    public int FsmNo { get; set; } = 0;
}
