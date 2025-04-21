using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

public class BadStatusCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BadStatusCondition);

    [JsonPropertyName("badStatusHash_")]
    public uint BadStatusHash { get; set; } = 0;
}
