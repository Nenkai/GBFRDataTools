using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Online;

public class CheckMatchingResult : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckMatchingResult);

    [JsonPropertyName("resultType_")]
    public EnumString ResultType { get; set; } // Offset 0x38
}
