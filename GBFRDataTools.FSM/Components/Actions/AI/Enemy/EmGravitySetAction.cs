using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmGravitySetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGravitySetAction);

    [JsonPropertyName("gOptionIdx_")]
    public int GOptionIdx { get; set; } = 0;

    [JsonPropertyName("gOptionTiming_")]
    public int GOptionTiming { get; set; } = 0;

    [JsonPropertyName("isUndoEnd_")]
    public bool IsUndoEnd { get; set; } = false;
}
