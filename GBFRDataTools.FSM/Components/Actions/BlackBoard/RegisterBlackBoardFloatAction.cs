using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class RegisterBlackBoardFloatAction : RegisterBlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardFloatAction);

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0;

    public override string? GetCaption()
    {
        return $"{ValueName} = {Value}";
    }
}