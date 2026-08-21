using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class RegisterBlackBoardIntAction : RegisterBlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardIntAction);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

    public override string? GetCaption()
    {
        return $"{ValueName} = {Value}";
    }
}