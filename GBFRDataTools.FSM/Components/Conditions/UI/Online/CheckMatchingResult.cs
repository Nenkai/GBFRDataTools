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
    public EnumString<CheckMatchingResultType> ResultType { get; set; } // Offset 0x38
}

public enum CheckMatchingResultType
{
    /* 
     * 成功 = 1,
       キャンセル終了 = 2,
       エラー終了 = 3,
    */
    Success = 1,
    CancellationCompleted = 2,
    ErrorEnded = 3,
}