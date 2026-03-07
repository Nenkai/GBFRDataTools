using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.PyetA;

public class Em3100ThreatAttackOrderAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100ThreatAttackOrderAction);

    [JsonPropertyName("orderType_")]
    public int OrderType { get; set; } = 0; // Offset 0x34

    public Em3100ThreatAttackOrderAction()
    {
    }
}

