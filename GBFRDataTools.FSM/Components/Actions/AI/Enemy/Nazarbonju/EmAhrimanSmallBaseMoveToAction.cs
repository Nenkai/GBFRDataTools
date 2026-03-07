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

public class EmAhrimanSmallBaseMoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseMoveToAction);

    [JsonPropertyName("customFlyParam_")]
    public bool CustomFlyParam { get; set; } = false; // Offset 0x59

    [JsonPropertyName("flyParam_")]
    public CharaFlyParam FlyParam { get; set; } // Offset 0x60

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 5f; // Offset 0x80

    [JsonPropertyName("isClearFlyVelocity_")]
    public bool IsClearFlyVelocity { get; set; } = false; // Offset 0x58

    [JsonPropertyName("distanceXZ_")]
    public float DistanceXZ { get; set; } = 2f; // Offset 0x84

    [JsonPropertyName("checkDefault_")]
    public bool CheckDefault { get; set; } = true; // Offset 0x88

    [JsonPropertyName("distanceY_")]
    public float DistanceY { get; set; } = 0.3f; // Offset 0x8C

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x90

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x94

    [JsonPropertyName("offMeshLinkMoveSec_")]
    public float OffMeshLinkMoveSec { get; set; } = 2f; // Offset 0x98

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 8f; // Offset 0x9C

    public EmAhrimanSmallBaseMoveToAction()
    {
    }
}
