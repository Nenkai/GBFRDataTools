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

public class ClearShortStory : QuestActionComponent
{
    [JsonPropertyName("questId_")]
    public uint QuestId { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}(questId: {QuestId:X6})";
        return str;
    }
}
