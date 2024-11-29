using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetShakeCamera : QuestActionComponent
{
    [JsonPropertyName("enableShakeCam_")]
    public bool EnableShakeCam { get; set; } = false;

    [JsonPropertyName("priority_")]
    public int Priority { get; set; } = 0;

    [JsonPropertyName("axisAdd_")]
    public /* cVec4 */ Vector4 AxisAdd { get; set; } = new Vector4(1.0f, 0.0f, 0.0f, 1.0f);

    [JsonPropertyName("axisRot_")]
    public /* cVec4 */ Vector4 AxisRot { get; set; } = Vector4.UnitW;

    [JsonPropertyName("shakeSpanTime_")]
    public float ShakeSpanTime { get; set; } = 1.0f;

    [JsonPropertyName("shakeTimeMax_")]
    public float ShakeTimeMax { get; set; } = 0.0f;

    [JsonPropertyName("decreaseRate_")]
    public float DecreaseRate { get; set; } = 1.0f;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
