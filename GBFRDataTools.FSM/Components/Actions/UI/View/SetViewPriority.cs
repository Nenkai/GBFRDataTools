using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.View;

public class SetViewPriority : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetViewPriority);

    [JsonPropertyName("views_")]
    public BindingList<string> Views { get; set; } = []; // Offset 0x30

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("default_")]
    public bool Default { get; set; } = false; // Offset 0x4C

    [JsonPropertyName("endreset_")]
    public bool Endreset { get; set; } = true; // Offset 0x4D

    public SetViewPriority()
    {
    }
}
