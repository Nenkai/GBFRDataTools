using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.Battle;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1303MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1303MoveAction);

    [JsonPropertyName("moveSec_")]
    public float MoveSec { get; set; } = 3f; // Offset 0x78

    [JsonPropertyName("moveLength_")]
    public float MoveLength { get; set; } = 8f; // Offset 0x7C

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } // Offset 0x68

    public Em1303MoveAction()
    {
    }
}
