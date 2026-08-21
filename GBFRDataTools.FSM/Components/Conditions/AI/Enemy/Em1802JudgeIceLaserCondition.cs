using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em1802JudgeIceLaserCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802JudgeIceLaserCondition);

    [JsonPropertyName("minRangeDis_")]
    public float MinRangeDis { get; set; } = 10f; 

    [JsonPropertyName("maxRangeDis_")]
    public float MaxRangeDis { get; set; } = 40f; 

    [JsonPropertyName("rangeAngle_")]
    public float RangeAngle { get; set; } = 40f; 
}
