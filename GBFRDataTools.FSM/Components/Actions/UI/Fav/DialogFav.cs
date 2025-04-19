using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fav;

public class DialogFav : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogFav);

    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } // Offset 0x30

    [JsonPropertyName("type_")]
    public EnumString<DialogFavType> Type { get; set; } // Offset 0x50
}

public enum DialogFavType
{
    Type0 = 0,
    Type1 = 1,
}