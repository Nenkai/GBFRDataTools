using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SystemMenuOverrideSet : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SystemMenuOverrideSet);

    [JsonPropertyName("overrideState_")]
    public bool OverrideState { get; set; } = false; // Offset 0x30
}
