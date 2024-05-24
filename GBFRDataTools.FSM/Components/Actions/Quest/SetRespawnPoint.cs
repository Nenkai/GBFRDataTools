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

public class SetRespawnPoint : QuestActionComponent
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; }

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; }


    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
