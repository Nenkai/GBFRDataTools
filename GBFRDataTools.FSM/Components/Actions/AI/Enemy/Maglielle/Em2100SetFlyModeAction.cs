using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SetFlyModeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SetFlyModeAction);

    [JsonPropertyName("setModeType_")]
    public int SetModeType { get; set; } = 0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}