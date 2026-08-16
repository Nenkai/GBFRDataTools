using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmGroupCombinationCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmGroupCombinationCondition);

    [JsonPropertyName("condition_")]
    public int Condition { get; set; } = 0;
}
