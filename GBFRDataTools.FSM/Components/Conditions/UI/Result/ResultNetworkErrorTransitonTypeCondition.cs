using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Result;

public class ResultNetworkErrorTransitonTypeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultNetworkErrorTransitonTypeCondition);

    [JsonPropertyName("type_")]
    public EnumString<ResultNetworkErrorTransitionTypeConditionType> Type { get; set; } // Offset 0x38

    public ResultNetworkErrorTransitonTypeCondition()
    {
    }
}

public enum ResultNetworkErrorTransitionTypeConditionType
{
    // 再挑戦なしノード = 1
    Type0 = 0,
    NoRetryMode = 1,
    Type2 = 2,
    Type3 = 3,

}
