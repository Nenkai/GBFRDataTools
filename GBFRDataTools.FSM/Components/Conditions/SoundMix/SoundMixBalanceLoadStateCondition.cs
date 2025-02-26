﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceLoadStateCondition : ConditionComponent
{
    [JsonPropertyName("loadState_")]
    public int LoadState { get; set; } = 0;
}
