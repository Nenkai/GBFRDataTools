using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

[Description("Sets (or registers) a int blackboard variable to the specified value.")]
public class BlackBoardIntAction : BlackBoardAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlackBoardIntAction);

    [JsonPropertyName("value_")]
    public int Value { get; set; } = 0;

    public override string GetCaption()
    {
        return $"Set {ValueName} = {Value}";
    }
}
