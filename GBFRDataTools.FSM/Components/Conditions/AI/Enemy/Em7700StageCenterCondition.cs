using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7700StageCenterCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700StageCenterCondition);

    [JsonPropertyName("checkRadius_")]
    public float CheckRadius { get; set; } = 3f; // Offset 0x38

    public Em7700StageCenterCondition()
    {
    }
}