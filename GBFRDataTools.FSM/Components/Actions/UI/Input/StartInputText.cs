using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Input;

public class StartInputText : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(StartInputText);

    [JsonPropertyName("enableDebugRandom_")]
    public bool EnableDebugRandom { get; set; } = false; // Offset 0x30

    public StartInputText()
    {
    }
}
