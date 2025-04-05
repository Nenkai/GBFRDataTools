﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Tayuitar;

public class Em1900UpdateDPSCheckAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900UpdateDPSCheckAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("isCheckLastAction_")]
    public bool IsCheckLastAction { get; set; } = false;
}
