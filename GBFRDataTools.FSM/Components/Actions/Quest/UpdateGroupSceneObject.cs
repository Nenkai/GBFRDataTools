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

public class UpdateGroupSceneObject : QuestActionComponent
{
    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; }

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; }

    [JsonPropertyName("active_")]
    public bool Active { get; set; }


    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
