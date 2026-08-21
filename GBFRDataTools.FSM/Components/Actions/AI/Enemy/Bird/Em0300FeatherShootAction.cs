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

public class Em0300FeatherShootAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0300FeatherShootAction);

    [JsonPropertyName("height_")]
    public float Height { get; set; } = 2f; 

    [JsonPropertyName("leaveDistance_")]
    public float LeaveDistance { get; set; } = 3f; 

    [JsonPropertyName("moveTime_")]
    public float MoveTime { get; set; } = 1f; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 1f; 
}
