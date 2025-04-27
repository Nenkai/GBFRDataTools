using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lilith;

public class Em2400CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400CounterAction);

    [JsonPropertyName("isWarp_")]
    public bool IsWarp { get; set; } = false; // Offset 0x50

    public Em2400CounterAction()
    {
    }
}
