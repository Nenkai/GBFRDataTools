using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms;

public class Em1800ClearDamageAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ClearDamageAction);

    [JsonPropertyName("clearTiming_")]
    public int ClearTiming { get; set; } = 0;
}
