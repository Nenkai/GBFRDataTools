using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500UndergroundGayserAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500UndergroundGayserAction);

    [JsonPropertyName("beforeSeconds_")]
    public float BeforeSeconds { get; set; } = 1f; 

    [JsonPropertyName("afterSeconds_")]
    public float AfterSeconds { get; set; } = 3f; 
}