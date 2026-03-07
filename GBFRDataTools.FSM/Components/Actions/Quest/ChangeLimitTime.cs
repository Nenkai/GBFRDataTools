using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ChangeLimitTime : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeLimitTime);

    [JsonPropertyName("second_")]
    public float Second { get; set; } = 0f; // Offset 0x48

    [JsonPropertyName("isPlusTime_")]
    public bool IsPlusTime { get; set; } = true; // Offset 0x4C

    public ChangeLimitTime()
    {
    }
}
