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

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckTimer : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckTimer);

    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; } = 0;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0;

    [JsonPropertyName("useDifficulty_")]
    public bool UseDifficulty { get; set; } = false;

    [JsonPropertyName("difficultyTimes_")]
    public BindingList<float> DifficultyTimes { get; set; } = []; // std::vector<float>

    [JsonPropertyName("isBasedQuestLimitTimer_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    [Description("Added in Endless Ragnarok.")]
    public bool IsBasedQuestLimitTimer { get; set; } = false;

}
