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

public class RotateSkyCube : QuestActionComponent
{
    [JsonPropertyName("rotate_")]
    public cVec4 Rotate { get; set; }

    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; }


    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
