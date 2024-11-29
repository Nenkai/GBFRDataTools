using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetClearMode : QuestActionComponent
{
    [JsonPropertyName("clearPos_")]
    public ulong ClearPos { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- ClearPos: {ClearPos}";

        return str;
    }
}
