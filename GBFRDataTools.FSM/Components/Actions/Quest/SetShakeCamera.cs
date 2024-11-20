using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetShakeCamera : QuestActionComponent
{
    [JsonPropertyName("enableShakeCam_")]
    public bool EnableShakeCam { get; set; }

    [JsonPropertyName("priority_")]
    public int Priority { get; set; }

    [JsonPropertyName("axisAdd_")]
    public cVec4 AxisAdd { get; set; }

    [JsonPropertyName("axisRot_")]
    public cVec4 AxisRot { get; set; }

    [JsonPropertyName("shakeSpanTime_")]
    public float ShakeSpanTime { get; set; }

    [JsonPropertyName("shakeTimeMax_")]
    public float ShakeTimeMax { get; set; }

    [JsonPropertyName("decreaseRate_")]
    public float DecreaseRate { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
