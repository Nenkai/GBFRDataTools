using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Ba;

public class LiftedObjectAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LiftedObjectAction);

    [JsonPropertyName("liftupState_")]
    public int LiftupState { get; set; } = 0;

    [JsonPropertyName("isMultiLiftupState_")]
    public bool IsMultiLiftupState { get; set; } = false;
}