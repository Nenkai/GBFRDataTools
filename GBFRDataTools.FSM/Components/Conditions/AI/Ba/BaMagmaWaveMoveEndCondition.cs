﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Ba;

public class BaMagmaWaveMoveEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BaMagmaWaveMoveEndCondition);
}