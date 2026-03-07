using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class GotoNode : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(GotoNode);

    [JsonPropertyName("eventName_")]
    public string EventName { get; set; } // Offset 0x30
}
