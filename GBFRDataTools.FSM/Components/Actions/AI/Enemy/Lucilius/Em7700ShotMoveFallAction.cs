using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700ShotMoveFallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700ShotMoveFallAction);

    [JsonPropertyName("velocityBegin_")]
    public float VelocityBegin { get; set; } = 0f; // Offset 0x44

    [JsonPropertyName("acceleration_")]
    public float Acceleration { get; set; } = 0f; // Offset 0x48

    [JsonPropertyName("slowTimeRate_")]
    public float SlowTimeRate { get; set; } = 0.1f; // Offset 0x34

    [JsonPropertyName("minHeight_")]
    public float MinHeight { get; set; } = -10f; // Offset 0x40

    public Em7700ShotMoveFallAction()
    {
    }
}

