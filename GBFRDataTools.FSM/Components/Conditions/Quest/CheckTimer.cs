using GBFRDataTools.FSM.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckTimer : QuestConditionComponent
{
    [JsonPropertyName("timerId_")]
    public int TimerId { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("useDifficulty_")]
    public bool UseDifficulty { get; set; }

    [JsonPropertyName("difficultyTimes_")]
    public ElementArray<float> DifficultyTimes { get; set; }


    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- TimerId: {TimerId}\n";
        str += $"- Time: {Time}s\n";
        str += $"- UseDifficulty: {UseDifficulty}\n";

        return str;
    }
}
