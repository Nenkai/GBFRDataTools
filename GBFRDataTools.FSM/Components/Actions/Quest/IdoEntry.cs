﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class IdoEntry : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IdoEntry);

    [JsonPropertyName("maxCharacterLevel_")]
    public int MaxCharacterLevel { get; set; } = 42;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
