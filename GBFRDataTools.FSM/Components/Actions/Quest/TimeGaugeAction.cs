using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class TimeGaugeAction : QuestActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("label_")]
    public string Label { get; set; }

    [JsonPropertyName("useDifficulty_")]
    public bool UseDifficulty { get; set; }

    [JsonPropertyName("difficultyTimes_")]
    public BindingList<float> DifficultyTimes { get; set; }
}
