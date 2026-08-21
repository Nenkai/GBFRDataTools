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

public class Em7400PunchBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400PunchBeamAction);

    [JsonPropertyName("scaleX_")]
    public float ScaleX { get; set; } = 1f; 

    [JsonPropertyName("scaleY_")]
    public float ScaleY { get; set; } = 1f; 

    [JsonPropertyName("startRadius_")]
    public float StartRadius { get; set; } = 1f; 

    [JsonPropertyName("endRadius_")]
    public float EndRadius { get; set; } = 1f; 

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 1f; 

    [JsonPropertyName("attackHeight_")]
    public float AttackHeight { get; set; } = 1f; 
}
