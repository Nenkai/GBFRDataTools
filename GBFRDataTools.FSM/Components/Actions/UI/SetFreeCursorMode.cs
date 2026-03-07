using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetFreeCursorMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFreeCursorMode);

    [JsonPropertyName("mode_")]
    public int Mode { get; set; } = 0; // Offset 0x30

    public SetFreeCursorMode()
    {
    }
}
