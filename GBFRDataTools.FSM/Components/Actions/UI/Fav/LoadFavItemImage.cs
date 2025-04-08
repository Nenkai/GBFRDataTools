using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fav;

public class LoadFavItemImage : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LoadFavItemImage);

    [JsonPropertyName("type_")]
    public EnumString Type { get; set; } // Offset 0x30
}
