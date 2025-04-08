using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300DoppelSonicRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300DoppelSonicRushAction);

    [JsonPropertyName("startWaitTime_")]
    public float StartWaitTime { get; set; } = 4.15f;

    [JsonPropertyName("slashInterval_")]
    public float SlashInterval { get; set; } = 0.8f;

}
