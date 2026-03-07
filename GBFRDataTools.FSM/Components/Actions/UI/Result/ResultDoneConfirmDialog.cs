using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

public class ResultDoneConfirmDialog : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultDoneConfirmDialog);

    [JsonPropertyName("dialogID_")]
    public string DialogID { get; set; } // Offset 0x30

    public ResultDoneConfirmDialog()
    {
    }
}