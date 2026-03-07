using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000JumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000JumpAction);

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f; // Offset 0x38

    [JsonPropertyName("maxHeight_")]
    public float MaxHeight { get; set; } = 10f; // Offset 0x3C

    [JsonPropertyName("offsetLength_")]
    public float OffsetLength { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("targetPosName_")]
    public string TargetPosName { get; set; } // Offset 0x48

    public Em2000JumpAction()
    {
    }
}
