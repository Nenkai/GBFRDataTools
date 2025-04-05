using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Enemy.Quakadiles;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Nazarbonju;

public class Em0706SetFlyModeAction : Em0500SplineAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706SetFlyModeAction);

    [JsonPropertyName("setModeType_")]
    public int SetModeType { get; set; } = 0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;
}
