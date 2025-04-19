using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Result;

public class ResultCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultCheckCondition);

    [JsonPropertyName("checkType_")]
    public int CheckType { get; set; } = 0; // Offset 0x38

    public ResultCheckCondition()
    {
    }
}
