using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Furycane;

public class Em7201MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7201MoveToAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 2f; 

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; 

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; 

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = true; 

    [JsonPropertyName("isInterpolate_")]
    public bool IsInterpolate { get; set; } = false; 

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = 0.3f; 

    [JsonPropertyName("moveSpdNormal_")]
    public float MoveSpdNormal { get; set; } = 20f; 

    [JsonPropertyName("moveSpdBroken_")]
    public float MoveSpdBroken { get; set; } = 8f; 
}




