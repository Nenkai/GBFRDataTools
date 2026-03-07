using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Cutscene;

public class SkipCut : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SkipCut);

    [JsonPropertyName("skip_")]
    public bool Skip { get; set; } = false; // Offset 0x30
}
