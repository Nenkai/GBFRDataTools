using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

public class OpenFateQuestPlotDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenFateQuestPlotDialog);

    [JsonPropertyName("decideSE")]
    public bool DecideSE { get; set; } = true; // Offset 0x30
}
