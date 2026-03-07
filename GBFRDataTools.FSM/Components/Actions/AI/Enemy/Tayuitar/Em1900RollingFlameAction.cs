using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900RollingFlameAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900RollingFlameAction);

    [JsonPropertyName("minRollingMotionRate_")]
    public float MinRollingMotionRate { get; set; } = 0.5f; // Offset 0x9C

    [JsonPropertyName("maxRollingMotionRate_")]
    public float MaxRollingMotionRate { get; set; } = 1f; // Offset 0xA0

    [JsonPropertyName("addRollingMotionRateTime_")]
    public float AddRollingMotionRateTime { get; set; } = 3f; // Offset 0xA4

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 5f; // Offset 0xA8

    [JsonPropertyName("walkTime_")]
    public float WalkTime { get; set; } = 10f; // Offset 0xAC

    [JsonPropertyName("addUpbodyRotMax_")]
    public float AddUpbodyRotMax { get; set; } = 0.05f; // Offset 0xB0

    [JsonPropertyName("maxAddUpbodyRotRate_")]
    public float MaxAddUpbodyRotRate { get; set; } = 0.5f; // Offset 0xB4

    [JsonPropertyName("walkMotionRate_")]
    public float WalkMotionRate { get; set; } = 2.5f; // Offset 0xB8

    [JsonPropertyName("shotIntervalTime_")]
    public float ShotIntervalTime { get; set; } = 0.033f; // Offset 0xBC

    public Em1900RollingFlameAction()
    {
    }
}


