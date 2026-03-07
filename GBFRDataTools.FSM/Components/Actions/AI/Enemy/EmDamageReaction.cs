using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmDamageReaction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageReaction);

    [JsonPropertyName("behaviorTypeHash_")]
    [Description("Unique identifier (?)")]
    public uint BehaviorTypeHash { get; set; } = 0; // Offset 0x30

    public EmDamageReaction()
    {
    }
}
