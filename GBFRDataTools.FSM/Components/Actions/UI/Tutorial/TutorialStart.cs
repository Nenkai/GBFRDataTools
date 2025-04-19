using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using static GBFRDataTools.Entities.Parameters.Enemy.Em2100.Em2100Param.AIParam;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class TutorialStart : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(TutorialStart);

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;

    [JsonPropertyName("tutorialIDs_")]
    public BindingList<string> TutorialIDs { get; set; } = [];

    public override string GetCaption()
    {
        return string.Join("\n", TutorialIDs);
    }
}
