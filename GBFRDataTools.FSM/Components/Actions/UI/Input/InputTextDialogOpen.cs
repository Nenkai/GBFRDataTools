using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Input;

public class InputTextDialogOpen : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(InputTextDialogOpen);

    [JsonPropertyName("openSeOff_")]
    public bool OpenSeOff { get; set; } = false; // Offset 0x30

    public InputTextDialogOpen()
    {
    }
}
