using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class ExistEntity : QuestConditionComponent
{
    [JsonPropertyName("uniqueIdHash_")]
    public ulong UniqueIdHash { get; set; }

    [JsonPropertyName("checkPlayers_")]
    public bool CheckPlayers { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
