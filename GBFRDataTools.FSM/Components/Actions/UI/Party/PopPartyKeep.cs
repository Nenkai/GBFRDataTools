using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Party;

public class PopPartyKeep : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PopPartyKeep);

    [JsonPropertyName("modelReload_")]
    public bool ModelReload { get; set; } = false; // Offset 0x30

    [JsonPropertyName("discard_")]
    public bool Discard { get; set; } = false; // Offset 0x31

    [JsonPropertyName("togame_")]
    public bool Togame { get; set; } = false; // Offset 0x32
}
