using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

namespace GBFRDataTools.FSM.Components.Conditions.UI;

public class IsRequestDialogDLC : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsRequestDialogDLC);

    [JsonPropertyName("type_")]
    public EnumString<DialogDLCType> Type { get; set; } // Offset 0x38

    public IsRequestDialogDLC()
    {
    }
}
