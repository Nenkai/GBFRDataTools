using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520LaserAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520LaserAction);

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 2f; // Offset 0x134

    [JsonPropertyName("laserLength_")]
    public float LaserLength { get; set; } = 100f; // Offset 0x1F0

    [JsonPropertyName("preLoopTime_")]
    public float PreLoopTime { get; set; } = 1f; // Offset 0x1F4

    [JsonPropertyName("isSextuple_")]
    public bool IsSextuple { get; set; } = false; // Offset 0x130

    public Em7520LaserAction()
    {
    }
}
