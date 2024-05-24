using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class CallFinishSlow : QuestActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("rate_")]
    public float Rate { get; set; }

    [JsonPropertyName("rateEm_")]
    public float RateEm { get; set; }

    [JsonPropertyName("hasAutoFadeOut_")]
    public bool HasAutoFadeOut { get; set; }

    [JsonPropertyName("fadeId_")]
    public int FadeId { get; set; }

    [JsonPropertyName("seType_")]
    public int SeType { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}:\n";
        str += $"- Time: {Time}\n";
        str += $"- Rate: {Rate}\n";
        str += $"- RateEm: {RateEm}\n";
        str += $"- HasAutoFadeOut: {HasAutoFadeOut}\n";
        str += $"- FadeId: {FadeId}\n";
        str += $"- SeType: {SeType}";

        return str;
    }
}
