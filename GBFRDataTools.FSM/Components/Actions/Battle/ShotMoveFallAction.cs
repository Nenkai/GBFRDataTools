using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveFallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveFallAction);

    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 0f; 

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 0f;

    public override string? GetCaption()
    {
        return $"VelocityBegin: {VelocityBegin:F2}, Accel: {Acceleration:F2}";
    }
}
