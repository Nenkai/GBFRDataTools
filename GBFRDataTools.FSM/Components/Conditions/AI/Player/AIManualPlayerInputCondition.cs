using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Player;

[Description("Returns whether the player inputs any action.")]
public class AIManualPlayerInputCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIManualPlayerInputCondition);
}