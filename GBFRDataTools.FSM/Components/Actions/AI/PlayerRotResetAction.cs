using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class PlayerRotResetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerRotResetAction);

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0.0f;
}
