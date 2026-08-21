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
    public float MoveSec { get; set; } = 3f; 

    [JsonPropertyName("moveLength_")]
    public float MoveLength { get; set; } = 8f;

    [JsonPropertyName("easeParam_")]
    public EaseParam EaseParam { get; set; } = new();
}
