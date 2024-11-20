using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class Dialog : ActionComponent
{
    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; }

    [JsonPropertyName("bgType_")]
    public EnumString BgType { get; set; }

    [JsonPropertyName("openSeOff_")]
    public bool OpenSeOff { get; set; }

    [JsonPropertyName("isDifficulty_")]
    public bool IsDifficulty { get; set; }

    [JsonPropertyName("isCursorMemory_")]
    public bool IsCursorMemory { get; set; }

    public override string ToString()
    {
        return $"{nameof(Dialog)}({DialogID})";
    }
}
