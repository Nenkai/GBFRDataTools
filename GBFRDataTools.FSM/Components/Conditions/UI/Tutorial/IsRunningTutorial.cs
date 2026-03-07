using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Tutorial;

public class IsRunningTutorial : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsRunningTutorial);

    [JsonPropertyName("tutorialLabel_")]
    public string TutorialLabel { get; set; } = string.Empty;
}
