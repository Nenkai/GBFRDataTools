using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Input;

public class OnEndFilterInputText : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnEndFilterInputText);

    [JsonPropertyName("result_")]
    public EnumString<OnEndFilterInputTextResult> Result { get; set; } // Offset 0x30

    public OnEndFilterInputText()
    {
    }
}

public enum OnEndFilterInputTextResult
{
    Success = 0,
    Failure = 1,
}
