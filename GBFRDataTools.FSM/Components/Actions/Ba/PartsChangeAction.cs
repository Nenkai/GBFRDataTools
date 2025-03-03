using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class PartsChangeAction : ActionComponent
{
    [JsonPropertyName("partsIndex_")]
    [Editable(false)]
    public BindingList<int> PartsIndex { get; set; } = [.. Enumerable.Repeat(0, 16).ToList()]; // std::array<int,16>

    [JsonPropertyName("visible_")]
    public bool Visible { get; set; } = false;

    [JsonPropertyName("useIndex_")]
    public int UseIndex { get; set; } = 0;
}