using GBFRDataTools.Entities.Base;
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
    public BindingList<ViewPrioParam> Views { get; set; } = []; 

    [JsonPropertyName("count_")]
    public int Count { get; set; } = 0; 

    [JsonPropertyName("default_")]
    public bool Default { get; set; } = false; 

    [JsonPropertyName("endreset_")]
    public bool Endreset { get; set; } = true; 
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class ViewPrioParam
{
    [JsonPropertyName("view_")]
    public string? View { get; set; }

    [JsonPropertyName("layer_")]
    public EnumString<ViewPrioParamLayer> Layer { get; set; } = new();

    [JsonPropertyName("prio_")]
    public int Prio { get; set; } 
}

public enum ViewPrioParamLayer
{
    // There's likely more, i think there was a file that had the full list
    // Might be a ui asset preload file of sorts
    Menu020 = 15,
}
