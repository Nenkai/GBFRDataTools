using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.UI.Fav;

public class DialogFavRestore : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogFavRestore);

    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } // Offset 0x30
}
