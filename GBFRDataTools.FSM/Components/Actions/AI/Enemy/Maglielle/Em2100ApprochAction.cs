using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100ApprochAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100ApprochAction);

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f; // Offset 0x60

    [JsonPropertyName("targetDistance_")]
    public float TargetDistance { get; set; } = 1f; // Offset 0x64

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } // Offset 0x68

    public Em2100ApprochAction()
    {
    }
}