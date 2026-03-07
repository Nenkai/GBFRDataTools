using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.BlackBoard;

public class RegisterBlackBoardAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RegisterBlackBoardAction);

    [JsonPropertyName("valueName_")]
    public string ValueName { get; set; } = string.Empty;
}
