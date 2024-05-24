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

public class SetRollCameraWorld : QuestActionComponent
{
    [JsonPropertyName("rollWaveAxisWorld_")]
    public cVec4 RollWaveAxisWorld { get; set; }

    [JsonPropertyName("enableWave_")]
    public bool EnableWave { get; set; }

    [JsonPropertyName("enableRollWave_")]
    public bool EnableRollWave { get; set; }

    [JsonPropertyName("rollWaveDeg_")]
    public float RollWaveDeg { get; set; }

    [JsonPropertyName("rollWaveSpan_")]
    public float RollWaveSpan { get; set; }

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
