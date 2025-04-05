﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class BlackBoardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardAction);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; } = string.Empty;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}
