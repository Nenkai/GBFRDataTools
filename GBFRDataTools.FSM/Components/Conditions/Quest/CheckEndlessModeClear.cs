using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckEndlessModeClear : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckEndlessModeClear);

    [JsonPropertyName("difficulty_")]
    public int Difficulty { get; set; } = 0;
}
