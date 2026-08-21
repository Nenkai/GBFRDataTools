using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;
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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Bird;

public class Em0300AroundAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300AroundAction);

    [JsonPropertyName("posType_")]
    public int PosType { get; set; } = 0; 

    [JsonPropertyName("startPosMinDistance_")]
    public float StartPosMinDistance { get; set; } = 5f; 

    [JsonPropertyName("actionTime_")]
    public Vector2 ActionTime { get; set; } = new Vector2(3f, 6f); 

    [JsonPropertyName("aroundSpeed_")]
    public float AroundSpeed { get; set; } = 5f; 

    [JsonPropertyName("aroundAngle_")]
    public float AroundAngle { get; set; } = 1f; 

    [JsonPropertyName("heightAjustSpeed_")]
    public float HeightAjustSpeed { get; set; } = 2f; 
}
