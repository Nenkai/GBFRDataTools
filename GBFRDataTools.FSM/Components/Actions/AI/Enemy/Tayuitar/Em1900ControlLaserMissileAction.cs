using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Tayuitar;

public class Em1900ControlLaserMissileAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1900ControlLaserMissileAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("isRestart_")]
    public bool IsRestart { get; set; } = false;
}
