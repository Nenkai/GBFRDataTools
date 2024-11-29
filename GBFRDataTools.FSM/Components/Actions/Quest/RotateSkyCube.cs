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

public class RotateSkyCube : QuestActionComponent
{
    [JsonPropertyName("rotate_")]
    public /* cVec4 */ Vector4 Rotate { get; set; } = Vector4.UnitW;

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0.0f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();


    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
