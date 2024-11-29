using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class IdBahamutLvEditAction : QuestActionComponent
{
    [JsonPropertyName("level_")]
    public int Level { get; set; } = 0;

    [JsonPropertyName("isReset_")]
    public bool IsReset { get; set; } = false;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
