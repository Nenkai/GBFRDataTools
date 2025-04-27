using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100ParallelAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100ParallelAction);

    [JsonPropertyName("parallelIndex_")]
    public int ParallelIndex { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("isLimit_")]
    public bool IsLimit { get; set; } = true; // Offset 0x34

    public Em2100ParallelAction()
    {
    }
}