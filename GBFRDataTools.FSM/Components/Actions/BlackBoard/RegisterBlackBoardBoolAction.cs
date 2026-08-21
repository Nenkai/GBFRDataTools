using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class RegisterBlackBoardBoolAction : RegisterBlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardBoolAction);

    [JsonPropertyName("value_")]
    public bool Value { get; set; } = false;

    public override string? GetCaption()
    {
        return $"{ValueName} = {Value}";
    }
}