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
    public float StopTime { get; set; } = 2f;

    [JsonPropertyName("laserLength_")]
    public float LaserLength { get; set; } = 100f;

    [JsonPropertyName("preLoopTime_")]
    public float PreLoopTime { get; set; } = 1f;

    [JsonPropertyName("isSextuple_")]
    public bool IsSextuple { get; set; } = false;
}
