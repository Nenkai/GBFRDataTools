﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CompleteTutorialHudElement : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CompleteTutorialHudElement);

    [JsonPropertyName("popupID_")]
    public string PopupID { get; set; } = string.Empty;

    public override string ToString()
    {
        string str = $"{ComponentName}({PopupID})";

        return str;
    }
}
