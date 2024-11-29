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

public class SetMultiQuestEventPos : QuestActionComponent
{
    [JsonPropertyName("treasureBoxPointHash_")]
    public ulong TreasureBoxPointHash { get; set; } = 0;

    [JsonPropertyName("plPointHash_")]
    public ulong PlPointHash { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
