using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600RoundTripRushAction : Em1600BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600RoundTripRushAction);

    [JsonPropertyName("minRushTime_")]
    public float MinRushTime { get; set; } = 0.2f; 

    [JsonPropertyName("rushNum_")]
    public int RushNum { get; set; } = 2; 

    [JsonPropertyName("finishMovementRate_")]
    public float FinishMovementRate { get; set; } = 0.5f; 

    [JsonPropertyName("turnMovementRateXZ_")]
    public float TurnMovementRateXZ { get; set; } = 1f; 

    [JsonPropertyName("turnMovementRateY_")]
    public float TurnMovementRateY { get; set; } = 1f; 

    [JsonPropertyName("rushMovementRate_")]
    public float RushMovementRate { get; set; } = 1f; 
}

