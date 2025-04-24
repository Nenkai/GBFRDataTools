using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em0200FoundPlayerCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0200FoundPlayerCondition);

    [JsonPropertyName("checkAngle_")]
    public float CheckAngle { get; set; } = 0f; // Offset 0x38

    public Em0200FoundPlayerCondition()
    {
    }
}
