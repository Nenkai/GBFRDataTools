using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class Em7700ShotMoveOrbitAction : ActionComponent
{
    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; }

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; }

    [JsonPropertyName("radiusBegin_")]
    public float RadiusBegin { get; set; }

    [JsonPropertyName("radiusVelocity_")]
    public float RadiusVelocity { get; set; }

    [JsonPropertyName("downSpeed_")]
    public float DownSpeed { get; set; }

    [JsonPropertyName("lifeTime_")]
    public float LifeTime { get; set; }
}
