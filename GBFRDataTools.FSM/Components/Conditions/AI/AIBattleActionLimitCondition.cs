﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class AIBattleActionLimitCondition : ConditionComponent
{
    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;
}