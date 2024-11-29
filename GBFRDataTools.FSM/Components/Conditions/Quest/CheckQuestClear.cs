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

public class CheckQuestClear : QuestConditionComponent
{
    [JsonPropertyName("questId_")]
    public ulong QuestId { get; set; } = 0;

    [JsonPropertyName("clearNum_")]
    public uint ClearNum { get; set; } = 1;

    [JsonPropertyName("absolute_")]
    public bool Absolute { get; set; } = false;
}
