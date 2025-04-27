using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520RestraintPlayerAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520RestraintPlayerAction);

    [JsonPropertyName("restraintTime_")]
    public float RestraintTime { get; set; } = 10f; // Offset 0x13C

    [JsonPropertyName("shotEndTime_")]
    public float ShotEndTime { get; set; } = 0.5f; // Offset 0x140

    public Em7520RestraintPlayerAction()
    {
    }
}
