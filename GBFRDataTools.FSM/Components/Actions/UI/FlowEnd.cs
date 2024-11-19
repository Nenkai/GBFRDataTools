using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class FlowEnd : ActionComponent
{
    [JsonPropertyName("result_")]
    public int Result { get; set; }

    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; }
}
