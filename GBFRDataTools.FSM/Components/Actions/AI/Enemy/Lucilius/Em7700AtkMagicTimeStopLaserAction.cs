using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700AtkMagicTimeStopLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkMagicTimeStopLaserAction);

    [JsonPropertyName("isTimeStop_")]
    public bool IsTimeStop { get; set; } = true; // Offset 0x70

    [JsonPropertyName("timeStopWaitTime_")]
    public float TimeStopWaitTime { get; set; } = 5f; // Offset 0x74

    public Em7700AtkMagicTimeStopLaserAction()
    {
    }
}


