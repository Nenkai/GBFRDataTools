using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530FrozenDownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530FrozenDownAction);

    [JsonPropertyName("fallTime_")]
    public float FallTime { get; set; } = 2.0f;
}
