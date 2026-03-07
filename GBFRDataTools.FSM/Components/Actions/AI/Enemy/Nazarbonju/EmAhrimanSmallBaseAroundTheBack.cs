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

public class EmAhrimanSmallBaseAroundTheBack : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAhrimanSmallBaseAroundTheBack);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x88

    [JsonPropertyName("sideMoveOffset_")]
    public float SideMoveOffset { get; set; } = 10f; // Offset 0x8C

    [JsonPropertyName("frontMoveOffset_")]
    public float FrontMoveOffset { get; set; } = 10f; // Offset 0x90

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; // Offset 0x94

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; } = 1f; // Offset 0x98

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; // Offset 0x9C

    public EmAhrimanSmallBaseAroundTheBack()
    {
    }
}
