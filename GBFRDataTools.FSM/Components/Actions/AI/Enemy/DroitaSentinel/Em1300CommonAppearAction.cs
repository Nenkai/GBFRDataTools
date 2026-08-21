using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1300CommonAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1300CommonAppearAction);

    [JsonPropertyName("startYSpeed_")]
    public float StartYSpeed { get; set; } = 0.01f; 

    [JsonPropertyName("startZSpeed_")]
    public float StartZSpeed { get; set; } = 0.01f; 

    [JsonPropertyName("isBomb_")]
    public bool IsBomb { get; set; } = false; 
}
