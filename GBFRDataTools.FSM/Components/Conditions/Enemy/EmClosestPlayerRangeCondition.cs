using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmClosestPlayerRangeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmClosestPlayerRangeCondition);
    
    [JsonPropertyName("checkRange_")]
    public float CheckRange { get; set; } = 0;

    [JsonPropertyName("operatorType_")]
    public EmClosestPlayerRangeConditionOperatorType OperatorType { get; set; } = 0;

    [JsonPropertyName("isCheckXZ_")]
    public bool IsCheckXZ { get; set; } = true;
}


