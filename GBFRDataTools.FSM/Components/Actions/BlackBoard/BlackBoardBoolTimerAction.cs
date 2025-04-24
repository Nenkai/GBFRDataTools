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
    public string ValueName { get; set; } // Offset 0x48

    [JsonPropertyName("value_")]
    public bool Value { get; set; } = false; // Offset 0x68

    [JsonPropertyName("writeSec_")]
    public float WriteSec { get; set; } = 0f; // Offset 0x6C

    [JsonPropertyName("isUseBehaviorDeltaTime_")]
    public bool IsUseBehaviorDeltaTime { get; set; } = false; // Offset 0x70

    public override string GetCaption()
    {
        string str = $"{ValueName} - {Value} - {WriteSec}s";
        if (IsUseBehaviorDeltaTime)
            str += "(BehaviorDeltaTime)";
        return str;
    }

    public BlackBoardBoolTimerAction()
    {
    }
}
