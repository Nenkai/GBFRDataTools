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

public class AddCameraLength : QuestActionComponent
{
    [JsonPropertyName("enable_")]
    public bool Enable { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("dist_")]
    public float Dist { get; set; }

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; }

    [JsonPropertyName("camOffsetY_")]
    public float CamOffsetY { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
