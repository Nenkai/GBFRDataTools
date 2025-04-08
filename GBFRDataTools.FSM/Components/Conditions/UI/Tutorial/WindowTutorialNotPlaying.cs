using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.UI.Tutorial;

public class WindowTutorialNotPlaying : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(WindowTutorialNotPlaying);

    [JsonPropertyName("tutorialLabel_")]
    public string TutorialLabel { get; set; } // Offset 0x38

    public WindowTutorialNotPlaying()
    {
    }
}
