using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OminousForm;

public class Em2800WaveAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2800WaveAttackAction);

    [JsonPropertyName("waveNum_")]
    public int WaveNum { get; set; } = 10; 

    [JsonPropertyName("intervalTime_")]
    public float IntervalTime { get; set; } = 0.083333336f; 

    [JsonPropertyName("offsetDist_")]
    public float OffsetDist { get; set; } = 5f; 
}
