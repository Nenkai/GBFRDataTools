using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class PlayerSlotLockDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerSlotLockDialog);

    [JsonPropertyName("dialogName_")]
    public string DialogName { get; set; } // Offset 0x30
}
