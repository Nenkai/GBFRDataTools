using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[Description("Sets (or registers) a float blackboard variable to the specified value.")]
public class BlackBoardFloatAction : BlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardFloatAction);

    [JsonPropertyName("value_")]
    public float Value { get; set; } = 0.0f;

    public override string GetCaption()
    {
        return $"Set {ValueName} = {Value}";
    }
}
