using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI;

[Description("Returns whether the player inputs an attack input.")]
public class AIManualPlayerAttackInputCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIManualPlayerAttackInputCondition);
}
