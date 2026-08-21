using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100PlacementGuillotineAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100PlacementGuillotineAction);

    [JsonPropertyName("distance_")]
    public float Distance { get; set; } = 5f; 

    [JsonPropertyName("intervalSec_")]
    public float IntervalSec { get; set; } = 1.25f; 

    [JsonPropertyName("guillotineNum_")]
    public int GuillotineNum { get; set; } = 3; 
}