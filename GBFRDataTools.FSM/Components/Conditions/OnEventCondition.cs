using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class OnEventCondition : ConditionComponent
{
    [JsonPropertyName("type_")]
    public int Type { get; set; }

    [JsonPropertyName("id_")]
    public int Id { get; set; }
}