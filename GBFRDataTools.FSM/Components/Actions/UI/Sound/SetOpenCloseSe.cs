using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Sound;

public class SetOpenCloseSe : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetOpenCloseSe);

    [JsonPropertyName("open_")]
    public string Open { get; set; } // Offset 0x30

    [JsonPropertyName("close_")]
    public string Close { get; set; } // Offset 0x50

    public SetOpenCloseSe()
    {
    }
}