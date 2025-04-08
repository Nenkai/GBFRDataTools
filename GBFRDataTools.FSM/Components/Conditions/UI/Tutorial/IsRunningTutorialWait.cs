using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Tutorial;

public class IsRunningTutorialWait : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsRunningTutorialWait);

    [JsonPropertyName("waitName_")]
    public string WaitName { get; set; } = string.Empty;
}
