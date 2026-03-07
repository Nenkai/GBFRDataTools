using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1800BeamAfterStepCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800BeamAfterStepCondition);

    [JsonPropertyName("wallLength_")]
    public float WallLength { get; set; } = 0f; // Offset 0x38

    [JsonPropertyName("wallRadius_")]
    public float WallRadius { get; set; } = 0f; // Offset 0x3C

    public Em1800BeamAfterStepCondition()
    {
    }
}
