using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.UI.Fate;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

[Description("Sets fate episode state. Can be acquired with FateEpisodeState.")]
public class SetFateEpisodeFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFateEpisodeFlag);

    [JsonPropertyName("flagType_")]
    public EnumString<FateEpisodeStateType> FlagType { get; set; } = new();

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = true; 

    [JsonPropertyName("useSelectedFateID_")]
    public bool UseSelectedFateID { get; set; } = true; 

    [JsonPropertyName("fateID_")]
    public string? FateID { get; set; } 
}
