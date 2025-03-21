﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Tayuitar;

public class Em1900ControlRegPulseAction : ActionComponent
{
    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("isRestart_")]
    public bool IsRestart { get; set; } = false;

    [JsonPropertyName("isResetGuage_")]
    public bool IsResetGuage { get; set; } = false;
}
