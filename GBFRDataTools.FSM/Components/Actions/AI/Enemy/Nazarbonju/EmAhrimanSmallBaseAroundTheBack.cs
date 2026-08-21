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
    public float HomingAngle { get; set; } = 10f; 

    [JsonPropertyName("sideMoveOffset_")]
    public float SideMoveOffset { get; set; } = 10f; 

    [JsonPropertyName("frontMoveOffset_")]
    public float FrontMoveOffset { get; set; } = 10f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; } = 1f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; 
}
