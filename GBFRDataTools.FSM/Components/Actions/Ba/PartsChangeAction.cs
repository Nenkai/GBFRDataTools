using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class PartsChangeAction : ActionComponent
{
    [JsonPropertyName("partsIndex_")]
    public BindingList<int> PartsIndex { get; set; } // std::array<int,16>

    [JsonPropertyName("visible_")]
    public bool Visible { get; set; }

    [JsonPropertyName("useIndex_")]
    public int UseIndex { get; set; }
}