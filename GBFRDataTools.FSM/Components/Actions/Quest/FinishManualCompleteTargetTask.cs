﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class FinishManualCompleteTargetTask : QuestActionComponent
{
    [JsonPropertyName("label_")]
    public string Label { get; set; } = string.Empty;

    [JsonPropertyName("asFailed_")]
    public bool AsFailed { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
