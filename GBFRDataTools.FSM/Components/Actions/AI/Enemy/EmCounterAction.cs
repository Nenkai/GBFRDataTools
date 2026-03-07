using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmCounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmCounterAction);

    [JsonPropertyName("isRestart_")]
    public bool IsRestart { get; set; } = true;

    public override string GetCaption()
    {
        return $"IsRestart: {IsRestart}";
    }
}
