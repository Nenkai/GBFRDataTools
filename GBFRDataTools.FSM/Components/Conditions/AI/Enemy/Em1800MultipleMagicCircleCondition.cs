using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1800MultipleMagicCircleCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800MultipleMagicCircleCondition);

    [JsonPropertyName("createRate_")]
    public float CreateRate { get; set; } = 0.1f; // Offset 0x3C

    public Em1800MultipleMagicCircleCondition()
    {
    }
}
