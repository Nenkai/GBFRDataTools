using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Behemoth;

public class Em1700ShotHoldTargetMoveAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ShotHoldTargetMoveAction);

    [JsonPropertyName("homingTime_")]
    public float HomingTime { get; set; } = -1.0f;
}
