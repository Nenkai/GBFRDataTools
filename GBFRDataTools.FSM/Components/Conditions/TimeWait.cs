using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class TimeWait : ConditionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("fsmLabel_")]
    public string FsmLabel { get; set; }

}