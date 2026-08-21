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
    public BindingList<string> TextIDs { get; set; } = []; 

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; 
}
