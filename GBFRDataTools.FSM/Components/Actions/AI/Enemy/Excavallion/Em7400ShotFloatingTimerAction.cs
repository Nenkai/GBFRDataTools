using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Excavallion;

public class Em7400ShotFloatingTimerAction : ShotAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7400ShotFloatingTimerAction);

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 0.0f;

    [JsonPropertyName("isForceSet_")]
    public bool IsForceSet { get; set; } = false;
}
