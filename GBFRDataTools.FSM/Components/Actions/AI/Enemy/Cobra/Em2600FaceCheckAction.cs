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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600FaceCheckAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600FaceCheckAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0.5f; 

    [JsonPropertyName("faceCheckTimer_")]
    public float FaceCheckTimer { get; set; } = 10f; 

    [JsonPropertyName("isCheckTimer_")]
    public bool IsCheckTimer { get; set; } = true; 
}

