using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500SplineAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500SplineAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 1.0f;

    [JsonPropertyName("height_")]
    public float Height { get; set; } = 10.0f;

    [JsonPropertyName("rotateDirection_")]
    public bool RotateDirection { get; set; } = false;

    [JsonPropertyName("endTimer_")]
    public bool EndTimer { get; set; } = true;
}