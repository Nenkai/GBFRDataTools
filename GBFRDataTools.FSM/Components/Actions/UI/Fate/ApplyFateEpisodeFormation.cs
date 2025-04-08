using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

public class ApplyFateEpisodeFormation : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ApplyFateEpisodeFormation);

    [JsonPropertyName("ignoreChar_")]
    public bool IgnoreChar { get; set; } = false; // Offset 0x30
}
