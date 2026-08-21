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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wolf;

public class Em0200WatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200WatchingAction);

    [JsonPropertyName("motionType_")]
    public int MotionType { get; set; } = 0; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.2f; 

    [JsonPropertyName("playSec_")]
    public float PlaySec { get; set; } = 0f; 

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = -1f; 

    [JsonPropertyName("frontRunEndDistance_")]
    public float FrontRunEndDistance { get; set; } = 20f; 

    [JsonPropertyName("stopCheckLength_")]
    public float StopCheckLength { get; set; } = 5f; 
}
