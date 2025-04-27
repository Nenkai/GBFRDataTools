using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Excavallion;

public class Em7400LongStepDirectionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400LongStepDirectionAction);

    [JsonPropertyName("checkOffsetY_")]
    public float CheckOffsetY { get; set; } = 80f; // Offset 0x30

    [JsonPropertyName("checkLength_")]
    public float CheckLength { get; set; } = 300f; // Offset 0x34

    [JsonPropertyName("checkDirFlag_")]
    public uint CheckDirFlag { get; set; } = 0xFFFFFFFF; // Offset 0x38

    public Em7400LongStepDirectionAction()
    {
    }
}
