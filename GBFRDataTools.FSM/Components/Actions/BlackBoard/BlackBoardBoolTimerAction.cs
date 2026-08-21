using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class BlackBoardBoolTimerAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardBoolTimerAction);

    [JsonPropertyName("valueName_")]
    public string? ValueName { get; set; } 

    [JsonPropertyName("value_")]
    public bool Value { get; set; } = false; 

    [JsonPropertyName("writeSec_")]
    public float WriteSec { get; set; } = 0f; 

    [JsonPropertyName("isUseBehaviorDeltaTime_")]
    public bool IsUseBehaviorDeltaTime { get; set; } = false; 

    public override string? GetCaption()
    {
        string str = $"{ValueName} - {Value} - {WriteSec}s";
        if (IsUseBehaviorDeltaTime)
            str += "(BehaviorDeltaTime)";
        return str;
    }
}
