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

public class Em7700SelectTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700SelectTargetAction);

    [JsonPropertyName("isHlOnly_")]
    public bool IsHlOnly { get; set; } = true; // Offset 0x30

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 1; // Offset 0x34

    public Em7700SelectTargetAction()
    {
    }
}


