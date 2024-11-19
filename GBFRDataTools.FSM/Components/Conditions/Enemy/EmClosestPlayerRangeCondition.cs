using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions;

public class EmClosestPlayerRangeCondition : ConditionComponent
{
    [JsonPropertyName("checkRange_")]
    public float CheckRange { get; set; }

    [JsonPropertyName("operatorType_")]
    public OperatorType OperatorType { get; set; }

    [JsonPropertyName("isCheckXZ_")]
    public bool IsCheckXZ { get; set; }
}
