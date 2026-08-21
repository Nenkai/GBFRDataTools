using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeTimerElapsedTime : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeTimerElapsedTime);

    [JsonPropertyName("second_")]
    public float Second { get; set; } = 0f; 

    [JsonPropertyName("isPlusTime_")]
    public bool IsPlusTime { get; set; } = true; 

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;

    public override string? GetCaption()
    {
        string str = $"Second: {Second:F2}s";
        if (IsPlusTime)
            str += " (IsPlusTime)";
        return str;
    }
}
