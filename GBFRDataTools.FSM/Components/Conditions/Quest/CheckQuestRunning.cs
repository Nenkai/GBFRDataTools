using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckQuestRunning : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckQuestRunning);

    [JsonPropertyName("questId_")]
    public ulong QuestId { get; set; } = 0;
}
