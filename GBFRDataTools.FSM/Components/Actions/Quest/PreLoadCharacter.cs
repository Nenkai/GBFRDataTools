﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PreLoadCharacter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PreLoadCharacter);

    [JsonPropertyName("characterID_")]
    public uint CharacterID { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
