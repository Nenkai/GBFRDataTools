using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600GlideScratchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600GlideScratchAction);

    [JsonPropertyName("turningSpeed_")]
    public float TurningSpeed { get; set; } = 0.5f; 

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 1f; 

    [JsonPropertyName("tornadoFanRot_")]
    public float TornadoFanRot { get; set; } = 180f; 

    [JsonPropertyName("tornadoNum_")]
    public int TornadoNum { get; set; } = 8; 

    [JsonPropertyName("tornadoDelayTime_")]
    public float TornadoDelayTime { get; set; } = 1.6f; 

    [JsonPropertyName("maxRushDist_")]
    public float MaxRushDist { get; set; } = 30f; 
}

