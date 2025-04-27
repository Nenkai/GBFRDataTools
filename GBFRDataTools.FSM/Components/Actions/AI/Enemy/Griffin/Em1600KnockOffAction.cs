using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Griffin;

public class Em1600KnockOffAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1600KnockOffAction);

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.1f; // Offset 0x48

    [JsonPropertyName("downLoopTime_")]
    public float DownLoopTime { get; set; } = 3f; // Offset 0x4C

    public Em1600KnockOffAction()
    {
    }
}

