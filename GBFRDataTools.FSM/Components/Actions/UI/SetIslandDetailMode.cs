using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetIslandDetailMode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetIslandDetailMode);

    [JsonPropertyName("detailMode_")]
    public EnumString DetailMode { get; set; } // Offset 0x30

    [JsonPropertyName("reset_")]
    public bool Reset { get; set; } = false; // Offset 0x60

    public SetIslandDetailMode()
    {
    }
}

