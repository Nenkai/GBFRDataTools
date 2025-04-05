using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions;

public class IndividuallyEndEventControlAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IndividuallyEndEventControlAction);

    [JsonPropertyName("isExecStart_")]
    public bool IsExecStart { get; set; } = true;
}
