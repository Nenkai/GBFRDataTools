using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetQuestRank : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetQuestRank);

    [JsonPropertyName("rank_")]
    public int Rank { get; set; } = 0;

    public override string? GetCaption()
    {
        return $"Rank: {Rank}";
    }
}
