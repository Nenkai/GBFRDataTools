using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetDirectMainMenuTop : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDirectMainMenuTop);

    [JsonPropertyName("direct_")]
    public bool Direct { get; set; } = false; // Offset 0x30
}
