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
    public bool CustomFlyParam { get; set; } = false; // Offset 0x4E

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x50

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x70

    [JsonPropertyName("isClearFlyVelocity_")]
    public bool IsClearFlyVelocity { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("isEndClearFlyVelocity_")]
    public bool IsEndClearFlyVelocity { get; set; } = false; // Offset 0x4D

    [JsonPropertyName("distanceXZ_")]
    public float DistanceXZ { get; set; } = 2f; // Offset 0x74

    [JsonPropertyName("checkDefault_")]
    public bool CheckDefault { get; set; } = true; // Offset 0x78

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 0.3f; // Offset 0x7C

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x80

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x84

    [JsonPropertyName("useMoveLimitTimer_")]
    public bool UseMoveLimitTimer { get; set; } = false; // Offset 0x88

    [JsonPropertyName("moveLimitTimer_")]
    public float MoveLimitTimer { get; set; } = 3f; // Offset 0x8C

    [JsonPropertyName("isBattleAreaCenterMove_")]
    public bool IsBattleAreaCenterMove { get; set; } = false; // Offset 0x90

    public Em0706MoveToAction()
    {
    }
}