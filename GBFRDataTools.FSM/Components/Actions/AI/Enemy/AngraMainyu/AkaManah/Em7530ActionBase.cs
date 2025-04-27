using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530ActionBase : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530ActionBase);

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 5f; // Offset 0x60

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = 2f; // Offset 0x64

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 2f; // Offset 0x68

    [JsonPropertyName("stopLength_")]
    public float StopLength { get; set; } = 5f; // Offset 0x50

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 5f; // Offset 0x54

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.5f; // Offset 0x5C
}
