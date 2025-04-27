using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.Daeva;

public class Em7520DimensionObjectAction : Em7520ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7520DimensionObjectAction);

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 2f; // Offset 0x150

    public Em7520DimensionObjectAction()
    {
    }
}
