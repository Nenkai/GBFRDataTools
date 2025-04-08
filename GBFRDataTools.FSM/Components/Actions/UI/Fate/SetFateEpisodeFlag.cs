using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fate;

public class SetFateEpisodeFlag : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetFateEpisodeFlag);

    [JsonPropertyName("flagType_")]
    public EnumString FlagType { get; set; } // Offset 0x30

    [JsonPropertyName("flag_")]
    public bool Flag { get; set; } = true; // Offset 0x60

    [JsonPropertyName("useSelectedFateID_")]
    public bool UseSelectedFateID { get; set; } = true; // Offset 0x61

    [JsonPropertyName("fateID_")]
    public string FateID { get; set; } // Offset 0x68
}
