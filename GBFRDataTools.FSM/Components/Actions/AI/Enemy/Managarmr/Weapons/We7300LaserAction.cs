using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300LaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300LaserAction);

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 1f; 

    [JsonPropertyName("hormingTime_")]
    public Vector4 HormingTime { get; set; } = new Vector4(0.5f, 0.5f, 1f, 1f); 

    [JsonPropertyName("postTime_")]
    public float PostTime { get; set; } = 0.5f; 
}