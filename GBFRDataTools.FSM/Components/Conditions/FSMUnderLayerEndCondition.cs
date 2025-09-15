using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

[Description("Returns whether a child layer created by the previous node is completed by an IsEndTransition transition.")]
public class FSMUnderLayerEndCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FSMUnderLayerEndCondition);
}
