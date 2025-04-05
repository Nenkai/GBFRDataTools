using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmAttackReactionCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAttackReactionCondition);

    [JsonPropertyName("attackReactionIndex_")]
    public int AttackReactionIndex { get; set; } = 0;
}
