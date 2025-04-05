using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class LiftedObjectStateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(LiftedObjectStateCondition);

    [JsonPropertyName("liftupState_")]
    public int LiftupState { get; set; } = 0;
}
