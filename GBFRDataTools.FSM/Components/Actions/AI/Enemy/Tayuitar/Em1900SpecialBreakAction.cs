using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900SpecialBreakAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900SpecialBreakAction);

    [JsonPropertyName("minWaitTime_")]
    public float MinWaitTime { get; set; } = 14.5f;
}
