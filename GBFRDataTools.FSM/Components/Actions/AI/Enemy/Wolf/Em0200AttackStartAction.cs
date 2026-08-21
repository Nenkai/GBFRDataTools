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

public class Em0200AttackStartAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200AttackStartAction);

    [JsonPropertyName("checkCameraDegree_")]
    public float CheckCameraDegree { get; set; } = 90f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.2f; 

    [JsonPropertyName("isCancel_")]
    public bool IsCancel { get; set; } = false; 

    [JsonPropertyName("stopCheckLength_")]
    public float StopCheckLength { get; set; } = 5f; 

    [JsonPropertyName("watchingType_")]
    public int WatchingType { get; set; } = 0; 

    [JsonPropertyName("actionTimeSec_")]
    public float ActionTimeSec { get; set; } = 0f; 
}
