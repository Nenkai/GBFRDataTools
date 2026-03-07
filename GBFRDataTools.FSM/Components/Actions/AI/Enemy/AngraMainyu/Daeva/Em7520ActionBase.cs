using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520ActionBase : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520MoveHormingShotAction);

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 5f; // Offset 0xD0

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = 2f; // Offset 0xD4

    [JsonPropertyName("endTime_")]
    public float EndTime { get; set; } = 2f; // Offset 0xD8

    [JsonPropertyName("stopLength_")]
    public float StopLength { get; set; } = 5f; // Offset 0xC0

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 5f; // Offset 0xC4

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.5f; // Offset 0xCC
}
