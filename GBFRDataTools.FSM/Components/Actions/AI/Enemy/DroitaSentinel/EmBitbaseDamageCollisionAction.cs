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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class EmBitbaseDamageCollisionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBitbaseDamageCollisionAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("collsionType_")]
    public int CollsionType { get; set; } = 0; // Offset 0x34

    public EmBitbaseDamageCollisionAction()
    {
    }
}
