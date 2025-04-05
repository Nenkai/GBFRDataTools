﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class OnEventCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnEventCondition);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;
}