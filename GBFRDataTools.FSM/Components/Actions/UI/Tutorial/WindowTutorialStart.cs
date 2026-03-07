using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.UI.Shop;

namespace GBFRDataTools.FSM.Components.Actions.UI.Tutorial;

public class WindowTutorialStart : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(WindowTutorialStart);

    [JsonPropertyName("tutorialID_")]
    public string TutorialID { get; set; } // Offset 0x30

    public WindowTutorialStart()
    {
    }
}
