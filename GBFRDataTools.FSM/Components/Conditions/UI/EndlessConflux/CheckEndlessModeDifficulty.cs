using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.EndlessConflux;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckEndlessModeDifficulty : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckEndlessModeDifficulty);

    [JsonPropertyName("difficulty_")]
    public int Difficulty { get; set; } = 0;
}
