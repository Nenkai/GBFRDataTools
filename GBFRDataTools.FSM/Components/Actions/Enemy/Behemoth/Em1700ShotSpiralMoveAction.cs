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
    public float MoveTime { get; set; }

    [JsonPropertyName("initRadius_")]
    public float InitRadius { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("addRotY_")]
    public float AddRotY { get; set; }

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; }

    [JsonPropertyName("accelerationRotY_")]
    public float AccelerationRotY { get; set; }
}
