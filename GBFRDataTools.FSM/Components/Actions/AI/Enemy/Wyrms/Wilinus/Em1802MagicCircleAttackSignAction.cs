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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802MagicCircleAttackSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802MagicCircleAttackSignAction);

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 1f; 

    [JsonPropertyName("signStartTime_")]
    public float SignStartTime { get; set; } = 1f; 

    [JsonPropertyName("scaleTime_")]
    public float ScaleTime { get; set; } = 1f; 

    [JsonPropertyName("circleScale_")]
    public float CircleScale { get; set; } = 1f; 

    [JsonPropertyName("signScale_")]
    public float SignScale { get; set; } = 1f; 
}
