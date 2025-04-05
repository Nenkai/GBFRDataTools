using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Conditions.Enemy;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

public class ShotParentAILevelCondition : EmAILevelCondition
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotParentAILevelCondition);
}