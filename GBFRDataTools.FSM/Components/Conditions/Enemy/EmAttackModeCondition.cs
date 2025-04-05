using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmAttackModeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmAttackModeCondition);

    [JsonPropertyName("checkMode_")]
    public int CheckMode { get; set; } = 0;
}
