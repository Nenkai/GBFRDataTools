using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetRollCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetRollCamera);

    [JsonPropertyName("enableRollWave_")]
    public bool EnableRollWave { get; set; } = false; // Offset 0x48

    [JsonPropertyName("rollWaveDeg_")]
    public float RollWaveDeg { get; set; } = 0f; // Offset 0x4C

    [JsonPropertyName("rollWaveSpan_")]
    public float RollWaveSpan { get; set; } = 1f; // Offset 0x50

    public SetRollCamera()
    {
    }
}
