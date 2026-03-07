using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class SetDialogArgumentText : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetDialogArgumentText);

    [JsonPropertyName("textIDs_")]
    public BindingList<string> TextIDs { get; set; } = []; // Offset 0x30 - std::vector<cyan::inplace_string<32>>

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x48
}
