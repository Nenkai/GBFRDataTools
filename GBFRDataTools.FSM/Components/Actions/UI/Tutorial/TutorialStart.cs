using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class TutorialStart : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TutorialStart);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("tutorialIDs_")]
    public BindingList<string> TutorialIDs { get; set; } = [];
}
