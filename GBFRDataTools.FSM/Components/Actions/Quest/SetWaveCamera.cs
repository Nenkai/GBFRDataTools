using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetWaveCamera : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetWaveCamera);

    [JsonPropertyName("enableOffsetWave_")]
    public bool EnableOffsetWave { get; set; } = false; // Offset 0x48

    [JsonPropertyName("offsetWaveOffset_")]
    public Vector2 OffsetWaveOffset { get; set; } = new Vector2(0f, 0f); // Offset 0x4C

    [JsonPropertyName("offsetWaveSpan_")]
    public Vector2 OffsetWaveSpan { get; set; } = new Vector2(0f, 0f); // Offset 0x54

    public SetWaveCamera()
    {
    }
}
