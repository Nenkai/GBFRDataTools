﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class StartLyriaNoteFlow : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StartLyriaNoteFlow);

    [JsonPropertyName("archiveId_")]
    public string ArchiveId { get; set; } = string.Empty;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
