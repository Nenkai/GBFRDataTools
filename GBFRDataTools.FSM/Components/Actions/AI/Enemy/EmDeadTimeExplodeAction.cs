using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmDeadTimeExplodeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDeadTimeExplodeAction);

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0.0f;

    [JsonPropertyName("presageSec_")]
    public float PresageSec { get; set; } = 0.5f;
}
