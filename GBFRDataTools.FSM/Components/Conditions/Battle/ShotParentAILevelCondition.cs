using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

namespace GBFRDataTools.FSM.Components.Conditions.Battle;

public class ShotParentAILevelCondition : EmAILevelCondition
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotParentAILevelCondition);

    public ShotParentAILevelCondition()
    {
        IsReverseSuccess = false;
        CheckLevel = 3;
        OperatorType = EmAILevelConditionOperatorType.Equal;
    }
}