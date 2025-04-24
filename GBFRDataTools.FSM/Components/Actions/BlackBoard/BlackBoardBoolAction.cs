using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[Description("Sets (or registers) a bool blackboard variable to the specified value.")]
public class BlackBoardBoolAction : BlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardBoolAction);

    [JsonPropertyName("value_")]
    public bool Value { get; set; } = false;

    public override string GetCaption()
    {
        return $"Set {ValueName} = {Value}";
    }
}
