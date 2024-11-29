using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Behemoth;

public class Em1700ShotSpiralMoveAction : ShotMoveBaseAction
{
    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1.0f;

    [JsonPropertyName("initRadius_")]
    public float InitRadius { get; set; } = 5.0f;

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 0.1f;

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; } = 0.1f;

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 0.1f;

    [JsonPropertyName("accelerationRotY_")]
    public float AccelerationRotY { get; set; } = 0.1f;
}
