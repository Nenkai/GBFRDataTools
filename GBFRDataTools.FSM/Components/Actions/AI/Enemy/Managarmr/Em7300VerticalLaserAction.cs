using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300VerticalLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300VerticalLaserAction);

    [JsonPropertyName("roarTargetHormingAngle_")]
    public float RoarTargetHormingAngle { get; set; } = 1f; 

    [JsonPropertyName("laserAddLength_")]
    public float LaserAddLength { get; set; } = 10f; 

    [JsonPropertyName("laserHormingMaxAngle_")]
    public Vector4 LaserHormingMaxAngle { get; set; } = new Vector4(5f, 5f, 5f, 10f); 
}
