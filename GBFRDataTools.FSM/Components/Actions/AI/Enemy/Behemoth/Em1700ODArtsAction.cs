using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ODArtsAction : Em1700CircleThunderAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ODArtsAction);

    [JsonPropertyName("jumpMinDist_")]
    public float JumpMinDist { get; set; } = 10f; // Offset 0x118

    [JsonPropertyName("jumpMaxDist_")]
    public float JumpMaxDist { get; set; } = 30f; // Offset 0x11C

    [JsonPropertyName("waveHeight_")]
    public float WaveHeight { get; set; } = 2f; // Offset 0x120

    [JsonPropertyName("insideWaveInnerRadius_")]
    public float InsideWaveInnerRadius { get; set; } = 10f; // Offset 0x124

    [JsonPropertyName("insideWaveOuterRadius_")]
    public float InsideWaveOuterRadius { get; set; } = 20f; // Offset 0x128

    [JsonPropertyName("outsideWaveInnerRadius_")]
    public float OutsideWaveInnerRadius { get; set; } = 20f; // Offset 0x12C

    [JsonPropertyName("outsideWaveOuterRadius_")]
    public float OutsideWaveOuterRadius { get; set; } = 40f; // Offset 0x130

    [JsonPropertyName("insideWaveTime_")]
    public float InsideWaveTime { get; set; } = 1f; // Offset 0x134

    [JsonPropertyName("outsideWaveTime_")]
    public float OutsideWaveTime { get; set; } = 2f; // Offset 0x138

    [JsonPropertyName("inhaleMinDist_")]
    public float InhaleMinDist { get; set; } = 8f; // Offset 0x13C

    [JsonPropertyName("inhaleMaxDist_")]
    public float InhaleMaxDist { get; set; } = 50f; // Offset 0x140

    [JsonPropertyName("isUseAssembleArea_")]
    public bool IsUseAssembleArea { get; set; } = false; // Offset 0x144

    public Em1700ODArtsAction()
    {
    }
}
