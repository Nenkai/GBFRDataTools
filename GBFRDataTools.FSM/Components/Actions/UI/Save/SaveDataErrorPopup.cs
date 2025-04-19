using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Save;

public class SaveDataErrorPopup : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SaveDataErrorPopup);

    [JsonPropertyName("isSave_")]
    public bool IsSave { get; set; } = false; // Offset 0x30

    public SaveDataErrorPopup()
    {
    }
}
