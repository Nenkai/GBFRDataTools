using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetBlacksmithMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetBlacksmithMode);

    [JsonPropertyName("mode_")]
    public SetBlacksmithMode Mode { get; set; } // Offset 0x30

    public SetBlacksmithMode()
    {
    }
}
