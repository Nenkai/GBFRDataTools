using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300EventAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300EventAction);

    [JsonPropertyName("event_")]
    public int Event { get; set; } = 0; // Offset 0x30

    public We7300EventAction()
    {
    }
}
