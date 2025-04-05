using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Wyrms;

public class Em1800WindBallMoveAction : ShotMoveStraightAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800WindBallMoveAction);

    [JsonPropertyName("setupRadius_")]
    public float SetupRadius { get; set; } = 2.0f;

    [JsonPropertyName("groundFloat_")]
    public float GroundFloat { get; set; } = 1.0f;
}
