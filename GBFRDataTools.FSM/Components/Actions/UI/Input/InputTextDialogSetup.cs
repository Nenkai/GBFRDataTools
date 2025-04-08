using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Input;

public class InputTextDialogSetup : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(InputTextDialogSetup);

    [JsonPropertyName("dialogIDName_")]
    public string DialogIDName { get; set; } // Offset 0x30

    [JsonPropertyName("inputWaitFlag_")]
    public bool InputWaitFlag { get; set; } = true; // Offset 0x54

    [JsonPropertyName("isUseWordFilter_")]
    public bool IsUseWordFilter { get; set; } = true; // Offset 0x55

    [JsonPropertyName("isCheckParentalControl_")]
    public bool IsCheckParentalControl { get; set; } = false; // Offset 0x56

    [JsonPropertyName("isGaussSetInputName_")]
    public bool IsGaussSetInputName { get; set; } = false; // Offset 0x57

    [JsonPropertyName("isForceOpenSeNone_")]
    public bool IsForceOpenSeNone { get; set; } = false; // Offset 0x58

    [JsonPropertyName("checkType_")]
    public EnumString CheckType { get; set; } // Offset 0x60

    public InputTextDialogSetup()
    {
    }
}
