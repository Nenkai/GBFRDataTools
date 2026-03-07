using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.UI.Result;

public class ResultEnableInputOperation : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ResultEnableInputOperation);

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false; // Offset 0x30

    public ResultEnableInputOperation()
    {
    }
}
