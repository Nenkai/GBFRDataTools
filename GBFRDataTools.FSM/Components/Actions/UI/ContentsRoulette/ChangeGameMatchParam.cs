using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.ContentsRoulette;

public class ChangeGameMatchParam : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ChangeGameMatchParam);

    [JsonPropertyName("matchType_")]
    public EnumString MatchType { get; set; } // Offset 0x30

    [JsonPropertyName("playStyle_")]
    public EnumString PlayStyle { get; set; } // Offset 0x60

    [JsonPropertyName("powerAdjust_")]
    public EnumString PowerAdjust { get; set; } // Offset 0x90
}
