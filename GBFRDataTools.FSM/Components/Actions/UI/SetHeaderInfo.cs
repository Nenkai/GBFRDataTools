using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI;

public class SetHeaderInfo : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetHeaderInfo);

    [JsonPropertyName("title_")]
    public string? Title { get; set; } 

    [JsonPropertyName("info_")]
    public string? Info { get; set; }

    [JsonPropertyName("type_")]
    public EnumString<CurrentMenuType> Type { get; set; } = new();
}
