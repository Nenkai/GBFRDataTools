using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkMoveHomingShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkMoveHomingShotAction);

    [JsonPropertyName("isLeftMove_")]
    public bool IsLeftMove { get; set; } = true;

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 10f;

    [JsonPropertyName("endWaitTime_")]
    public float EndWaitTime { get; set; } = 0.1f;
}

