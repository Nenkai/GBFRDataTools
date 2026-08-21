using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Cobra;

public class Em2600ChangeGroundMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2600ChangeGroundMoveAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 0f; 

    [JsonPropertyName("isAutoChange_")]
    public bool IsAutoChange { get; set; } = true; 

    [JsonPropertyName("changeMoveType_")]
    public int ChangeMoveType { get; set; } = 0; 
}
