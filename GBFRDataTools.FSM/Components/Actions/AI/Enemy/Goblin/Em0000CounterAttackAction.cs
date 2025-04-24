using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000CounterAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000CounterAttackAction);

    [JsonPropertyName("guid_")]
    public uint Guid { get; set; } = 0; // Offset 0x8

    [JsonPropertyName("parentGuid_")]
    public uint ParentGuid { get; set; } = 0xFFFFFFFF; // Offset 0xC

    public Em0000CounterAttackAction()
    {
    }
}
