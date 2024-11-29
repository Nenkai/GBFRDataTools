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

public class SetRollCameraWorld : QuestActionComponent
{
    [JsonPropertyName("rollWaveAxisWorld_")]
    public /* cVec4 */ Vector4 RollWaveAxisWorld { get; set; } = new Vector4(1.0f, 1.0f, 0.0f, 0.0f);

    [JsonPropertyName("enableWave_")]
    public bool EnableWave { get; set; } = true;

    [JsonPropertyName("enableRollWave_")]
    public bool EnableRollWave { get; set; } = false;

    [JsonPropertyName("rollWaveDeg_")]
    public float RollWaveDeg { get; set; } = 1.0f;

    [JsonPropertyName("rollWaveSpan_")]
    public float RollWaveSpan { get; set; } = 0.0f;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
