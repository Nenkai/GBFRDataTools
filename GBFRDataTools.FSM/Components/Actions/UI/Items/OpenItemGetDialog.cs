using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.UI.Dialog;

namespace GBFRDataTools.FSM.Components.Actions.UI.Items;

public class OpenItemGetDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OpenItemGetDialog);

    [JsonPropertyName("type_")]
    public EnumString<OpenItemGetDialogType> Type { get; set; } // Offset 0x30

    public OpenItemGetDialog()
    {
    }
}

public enum OpenItemGetDialogType
{
    // DLCエモート = 0
    // DLCカラー = 1
    DLCEmotes = 0,
    DLCColor = 1,
}
