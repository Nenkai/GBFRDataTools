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

public class SetMotionCameraToGameCamera : QuestActionComponent
{
    [JsonPropertyName("time_")]
    public float Time { get; set; }

    [JsonPropertyName("disableResetCamera_")]
    public bool DisableResetCamera { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
