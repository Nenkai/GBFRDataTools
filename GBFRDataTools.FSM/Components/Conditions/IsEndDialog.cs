﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class IsEndDialog : ConditionComponent
{
    [JsonPropertyName("includeClose_")]
    public bool IncludeClose { get; set; } = false;

    [JsonPropertyName("checkID_")]
    public bool CheckID { get; set; } = false;

    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } = string.Empty;
}
