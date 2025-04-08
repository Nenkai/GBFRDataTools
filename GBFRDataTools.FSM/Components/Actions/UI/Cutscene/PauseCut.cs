using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Cutscene;

public class PauseCut : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PauseCut);

    [JsonPropertyName("pause_")]
    public bool Pause { get; set; } = false; // Offset 0x30
}
