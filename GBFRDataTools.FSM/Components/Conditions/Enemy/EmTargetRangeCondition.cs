using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class EmTargetRangeCondition : ConditionComponent
{
    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; }

    [JsonPropertyName("operatorType_")]
    public int OperatorType { get; set; }

    [JsonPropertyName("isUseRangeXZ_")]
    public bool IsUseRangeXZ { get; set; }
}
