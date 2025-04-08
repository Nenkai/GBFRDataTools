using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

[Description("Opens a dialog with a simple message.")]
public class Dialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Dialog);

    [Description("Dialog to use. Refers to dialog table in the database.")]
    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } = string.Empty;

    [JsonPropertyName("bgType_")]
    public EnumString BgType { get; set; } = new();

    [Description("Whether to open with sound effects.")]
    [JsonPropertyName("openSeOff_")]
    public bool OpenSeOff { get; set; } = false;

    [JsonPropertyName("isDifficulty_")]
    public bool IsDifficulty { get; set; } = false;

    [JsonPropertyName("isCursorMemory_")]
    public bool IsCursorMemory { get; set; } = false;

    public override string ToString()
    {
        return $"{nameof(Dialog)}({DialogID})";
    }
}
