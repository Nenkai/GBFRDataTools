using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class ActionEndCondition : ConditionComponent
{
    [JsonPropertyName("isAllEnd_")]
    [Description("Ensures that all actions are completed before processing.")]
    public bool IsAllEnd { get; set; } = false;
}
