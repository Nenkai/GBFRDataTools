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

public class SetSoundListener : QuestActionComponent
{
    [JsonPropertyName("presetId_")]
    public int PresetId { get; set; } = 0;

    [JsonPropertyName("fadeTime_")]
    public float FadeTime { get; set; } = 0.0f;

    public override string ToString()
    {
        string str = $"{ComponentName}";
        return str;
    }
}
