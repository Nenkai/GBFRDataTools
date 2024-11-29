using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Lucilius;

public class Em7700ShotMoveOrbitAction : ActionComponent
{
    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 5.0f;

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 5.0f;

    [JsonPropertyName("radiusBegin_")]
    public float RadiusBegin { get; set; } = 2.0f;

    [JsonPropertyName("radiusVelocity_")]
    public float RadiusVelocity { get; set; } = 2.0f;

    [JsonPropertyName("downSpeed_")]
    public float DownSpeed { get; set; } = 1.0f;

    [JsonPropertyName("lifeTime_")]
    public float LifeTime { get; set; } = -1.0f;
}
