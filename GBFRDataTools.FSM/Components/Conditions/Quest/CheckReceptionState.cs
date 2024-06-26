﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckReceptionState : QuestConditionComponent
{
    [JsonPropertyName("state_")]
    public int State { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- State: {State}";

        return str;
    }
}
