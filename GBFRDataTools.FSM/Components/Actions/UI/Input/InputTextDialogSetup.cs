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
    public string? DialogIDName { get; set; } 

    [JsonPropertyName("inputWaitFlag_")]
    public bool InputWaitFlag { get; set; } = true; 

    [JsonPropertyName("isUseWordFilter_")]
    public bool IsUseWordFilter { get; set; } = true; 

    [JsonPropertyName("isCheckParentalControl_")]
    public bool IsCheckParentalControl { get; set; } = false; 

    [JsonPropertyName("isGaussSetInputName_")]
    public bool IsGaussSetInputName { get; set; } = false; 

    [JsonPropertyName("isForceOpenSeNone_")]
    public bool IsForceOpenSeNone { get; set; } = false; 

    [JsonPropertyName("checkType_")]
    public EnumString<InputTextDialogSetupCheckType> CheckType { get; set; } = new();

    public override string? GetCaption()
    {
        return $"{DialogIDName}";
    }
}

public enum InputTextDialogSetupCheckType
{
    // 伏せ字文字列 = 0,
    // 伏せ字単語 = 2,
    ObscureCharacterString = 0,
    WordsWithHiddenLetters = 2,
}
