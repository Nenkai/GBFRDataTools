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
    public float Second { get; set; } = 0f; // Offset 0x48

    [JsonPropertyName("isPlusTime_")]
    public bool IsPlusTime { get; set; } = true; // Offset 0x4C

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0; // Offset 0x50

    public ChangeTimerElapsedTime()
    {
    }
}
