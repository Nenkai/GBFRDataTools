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

public class Em0804ChainAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0804ChainAction);

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 2f; // Offset 0x40

    public Em0804ChainAction()
    {
    }
}
