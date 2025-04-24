using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500TailSlashAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500TailSlashAction);

    [JsonPropertyName("motionInterp_")]
    public float MotionInterp { get; set; } = 0.1f; // Offset 0x54

    [JsonPropertyName("startSpeedRate_")]
    public float StartSpeedRate { get; set; } = 0.92f; // Offset 0x58

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 3f; // Offset 0x5C

    [JsonPropertyName("beginSpeed_")]
    public float BeginSpeed { get; set; } = 15f; // Offset 0x60

    [JsonPropertyName("slideSpeedRate_")]
    public float SlideSpeedRate { get; set; } = 0.9f; // Offset 0x64

    public Em0500TailSlashAction()
    {
    }
}