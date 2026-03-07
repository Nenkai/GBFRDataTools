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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802IceLanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802IceLanceAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; // Offset 0x70

    [JsonPropertyName("launchInterval_")]
    public float LaunchInterval { get; set; } = 0.8f; // Offset 0x74

    [JsonPropertyName("firstGeneratingTime_")]
    public float FirstGeneratingTime { get; set; } = 0f; // Offset 0x78

    [JsonPropertyName("generatingIntervalTime_")]
    public float GeneratingIntervalTime { get; set; } = 0.2f; // Offset 0x7C

    [JsonPropertyName("iceLanceMax_")]
    public int IceLanceMax { get; set; } = 10; // Offset 0x80

    [JsonPropertyName("iceLanceCircleRadius_")]
    public float IceLanceCircleRadius { get; set; } = 7f; // Offset 0x84

    [JsonPropertyName("iceLanceCircleHeight_")]
    public float IceLanceCircleHeight { get; set; } = 13f; // Offset 0x88

    [JsonPropertyName("iceLanceStartAngle_")]
    public float IceLanceStartAngle { get; set; } = 90f; // Offset 0x8C

    public Em1802IceLanceAction()
    {
    }
}
