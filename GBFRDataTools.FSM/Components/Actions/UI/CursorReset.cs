using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class CursorReset : ActionComponent
{
    [JsonPropertyName("menuIDs_")]
    public BindingList<string> MenuIDs { get; set; } = [];

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0;
}
