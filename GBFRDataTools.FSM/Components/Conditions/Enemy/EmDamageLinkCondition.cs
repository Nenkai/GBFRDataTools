using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmDamageLinkCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageLinkCondition);

    [JsonPropertyName("isCheckReaction_")]
    public bool IsCheckReaction { get; set; } = true;
}
