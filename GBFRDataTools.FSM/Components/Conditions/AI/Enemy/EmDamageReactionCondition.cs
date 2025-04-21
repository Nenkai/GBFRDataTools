using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class EmDamageReactionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageReactionCondition);

    [JsonPropertyName("damageReactionStrHash_")]
    public uint DamageReactionStrHash { get; set; }
}
