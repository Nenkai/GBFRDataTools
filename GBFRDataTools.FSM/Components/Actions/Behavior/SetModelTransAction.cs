﻿using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class SetModelTransAction : ActionComponent
{
    [JsonPropertyName("isTrans_")]
    public bool IsTrans { get; set; } = true;
}