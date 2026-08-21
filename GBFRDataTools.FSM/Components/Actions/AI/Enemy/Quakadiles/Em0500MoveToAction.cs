using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500MoveToAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500MoveToAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 2f; 

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; 

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; 

    [JsonPropertyName("changeRangeCondition_")]
    public int ChangeRangeCondition { get; set; } = 1; 

    [JsonPropertyName("changeRange_")]
    public int ChangeRange { get; set; } = 0; 

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = true; 
}


