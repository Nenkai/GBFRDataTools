﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmEnableLiftupAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmEnableLiftupAction);

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = true; // Offset 0x30

    public EmEnableLiftupAction()
    {
    }
}