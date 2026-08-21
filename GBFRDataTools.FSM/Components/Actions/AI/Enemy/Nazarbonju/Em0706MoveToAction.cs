using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

public class Em0706MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706MoveToAction);

    [JsonPropertyName("customFlyParam_")]
    public bool CustomFlyParam { get; set; } = false;

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } = new();

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; 

    [JsonPropertyName("isClearFlyVelocity_")]
    public bool IsClearFlyVelocity { get; set; } = false; 

    [JsonPropertyName("isEndClearFlyVelocity_")]
    public bool IsEndClearFlyVelocity { get; set; } = false; 

    [JsonPropertyName("distanceXZ_")]
    public float DistanceXZ { get; set; } = 2f; 

    [JsonPropertyName("checkDefault_")]
    public bool CheckDefault { get; set; } = true; 

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 0.3f; 

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; 

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; 

    [JsonPropertyName("useMoveLimitTimer_")]
    public bool UseMoveLimitTimer { get; set; } = false; 

    [JsonPropertyName("moveLimitTimer_")]
    public float MoveLimitTimer { get; set; } = 3f; 

    [JsonPropertyName("isBattleAreaCenterMove_")]
    public bool IsBattleAreaCenterMove { get; set; } = false; 
}