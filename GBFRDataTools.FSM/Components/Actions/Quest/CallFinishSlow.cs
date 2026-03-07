using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallFinishSlow : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CallFinishSlow);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 2.0f;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 0.1f;

    [JsonPropertyName("rateEm_")]
    public float RateEm { get; set; } = 0.1f;

    [JsonPropertyName("hasAutoFadeOut_")]
    public bool HasAutoFadeOut { get; set; } = true;

    [JsonPropertyName("fadeId_")]
    public int FadeId { get; set; } = 0;

    [JsonPropertyName("seType_")]
    public int SeType { get; set; } = 0;
}
