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

public class Em7700MoveRunFrontAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700MoveRunFrontAction);

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f; // Offset 0x70

    [JsonPropertyName("stopTargetDistance_")]
    public float StopTargetDistance { get; set; } = 5f; // Offset 0x74

    public Em7700MoveRunFrontAction()
    {
    }
}


