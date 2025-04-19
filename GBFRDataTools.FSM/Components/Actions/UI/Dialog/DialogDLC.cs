using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
namespace GBFRDataTools.FSM.Components.Actions.UI.Dialog;

public class DialogDLC : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogDLC);

    [JsonPropertyName("type_")]
    public EnumString<DialogDLCType> Type { get; set; } // Offset 0x30

    public DialogDLC()
    {
    }
}

public enum DialogDLCType
{
    // 剥奪 = 0
    // 再有効 = 1
    Deactivation = 0,
    Reenablement = 1,
}