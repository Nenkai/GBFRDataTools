using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Cutscene;

public class DialogChara : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DialogChara);

    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } // Offset 0x30
}
