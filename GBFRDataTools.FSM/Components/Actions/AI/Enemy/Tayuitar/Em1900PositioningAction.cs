using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900PositioningAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900PositioningAction);

    [JsonPropertyName("targetDist_")]
    public float TargetDist { get; set; } = 10f; // Offset 0x70

    [JsonPropertyName("toleranceDist_")]
    public float ToleranceDist { get; set; } = 5f; // Offset 0x74

    public Em1900PositioningAction()
    {
    }
}


