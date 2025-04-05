using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class AddCameraLength : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AddCameraLength);

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = true;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;

    [JsonPropertyName("dist_")]
    public float Dist { get; set; } = 1.0f;

    [JsonPropertyName("camRate_")]
    public float CamRate { get; set; } = 0.5f;

    [JsonPropertyName("camOffsetY_")]
    public float CamOffsetY { get; set; } = 0f;
}
