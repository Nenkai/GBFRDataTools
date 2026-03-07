using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0804FallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0804FallAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 2f; // Offset 0x40

    [JsonPropertyName("startAnimSpd_")]
    public float StartAnimSpd { get; set; } = 1.6f; // Offset 0x44

    public Em0804FallAction()
    {
    }
}
