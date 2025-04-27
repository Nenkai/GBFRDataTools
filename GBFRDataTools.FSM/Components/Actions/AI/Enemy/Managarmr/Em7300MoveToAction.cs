using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300MoveToAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 2f; // Offset 0x44

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("checkDistance_")]
    public float CheckDistance { get; set; } = 0f; // Offset 0x4C

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x50

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = true; // Offset 0x54

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f; // Offset 0x58

    public Em7300MoveToAction()
    {
    }
}
