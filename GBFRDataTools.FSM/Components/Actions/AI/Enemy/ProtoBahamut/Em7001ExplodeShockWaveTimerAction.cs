using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001ExplodeShockWaveTimerAction : ShotAttackSignAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001ExplodeShockWaveTimerAction);

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 1.0f;

    [JsonPropertyName("isForceSet_")]
    public bool IsForceSet { get; set; } = false;
}
