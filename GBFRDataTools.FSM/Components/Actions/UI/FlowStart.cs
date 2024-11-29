using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class FlowStart : ActionComponent
{
    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = string.Empty;

    [JsonPropertyName("param_")]
    public int Param { get; set; } = 0;
}
