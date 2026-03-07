using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetPlayerRetireSelect : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPlayerRetireSelect);

    [JsonPropertyName("isRetire_")]
    public bool IsRetire { get; set; } = false; // Offset 0x30

    public SetPlayerRetireSelect()
    {
    }
}
